using UnityEngine;
using System.Collections;

public class DoorOpen : MonoBehaviour {
	private Vector3 offset;
	// Use this for initialization
	void Start () {
		offset = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if ((GameObject.Find("MainCharacterTest").GetComponent<TriggerScript>().triggerOn) || (GameObject.Find("Egg").GetComponent<TriggerScript>().triggerOn)) {
			transform.position = offset - (new Vector3 (0,5,0));
			}

		if (!GameObject.Find("MainCharacterTest").GetComponent<TriggerScript>().triggerOn && (!GameObject.Find("Egg").GetComponent<TriggerScript>().triggerOn)) {
			transform.position = offset;
		}

		if (GameObject.Find ("MainCharacterTest").GetComponent<TriggerScript> ().triggerOnPerm  || (GameObject.Find("Egg").GetComponent<TriggerScript>().triggerOnPerm)) {
			transform.position = offset - (new Vector3 (0,5,0));
		}
	}
}
