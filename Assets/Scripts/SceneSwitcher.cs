using UnityEngine;
using System.Collections;

public class SceneSwitcher : MonoBehaviour {

	public float fadeSpeed = 1.5f;
	public GUITexture guiTexture;
	
	private bool sceneStarting = true;

	public void SwitchScene(string scene) {
		guiTexture.enabled = false;
		FadeToBlack();
		
		if(guiTexture.color.a >= 0.95f) {
			guiTexture.color = Color.black;
			Application.LoadLevel(scene);
		}
	}

	void Awake() {
		guiTexture = new GUITexture ();
		//guiTexture.pixelInset = new Rect (0f, 0f, Screen.width, Screen.height);
	}

	void FadeToClear () {
		guiTexture.color = Color.Lerp(guiTexture.color, Color.clear, fadeSpeed * Time.deltaTime);
	}

	void FadeToBlack () {
		guiTexture.color = Color.Lerp (guiTexture.color, Color.black, fadeSpeed * Time.deltaTime);
	}

	void StartScene () {
		FadeToClear();

		if(guiTexture.color.a <= 0.05f) {
			guiTexture.color = Color.clear;
			guiTexture.enabled = false;

			sceneStarting = false;
		}
	}

	void Update () {
		if (sceneStarting) {
			StartScene();
		}
	}
}
