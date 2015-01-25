using UnityEngine;
using System.Collections;

public class EggLighting : MonoBehaviour {
	public Light eggLight;
	// Use this for initialization
	void Start () {
	

		eggLight = gameObject.GetComponentInChildren<Light>();
	}
	
	// Update is called once per frame
	void Update () {

		eggLight.intensity -= 0.01f;

	}
}
