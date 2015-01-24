using UnityEngine;
using System.Collections;

public class DoorOpen : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (GameObject.Find("PlayerController").GetComponent<PlayerController>().triggerOn) {
				transform.Rotate(new Vector3 (0, 1, 0));
			}
	}
}
