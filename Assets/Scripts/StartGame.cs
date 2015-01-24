using UnityEngine;
using System.Collections;


public class StartGame : MonoBehaviour {
	public float fadeMultiplier = 1f;

	public void changeToScene(string scene) {
//		while (guiText.color.a < 1) {
//			guiText.color.a += Time.deltaTime * fadeMultiplier;
//		}

		Application.LoadLevel (scene);
	}
}
