using UnityEngine;
using System.Collections;

public class DoorPermaOpen : MonoBehaviour {
	private Vector3 offset;
	// Use this for initialization
	void Start () {
		offset = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (GameObject.Find("PlayerController").GetComponent<TriggerScript>().triggerOn) {
			transform.position = offset - (new Vector3 (0,5,0));
		}
	}
}
