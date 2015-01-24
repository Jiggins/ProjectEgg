using UnityEngine;
using System.Collections;

public class Egg : MonoBehaviour {

	public Transform 	characterHands;

	public bool			pickedUp;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if(pickedUp) {
			transform.position = characterHands.position;
			transform.rotation = characterHands.rotation;
		}

	}
}
