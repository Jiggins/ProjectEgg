using UnityEngine;
using System.Collections;

public class TriggerScript : MonoBehaviour {

	public bool triggerOn = false;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
			
	}

	void OnTriggerEnter (Collider other){
		if ((other.tag == "Switch")) {
			triggerOn = true;
		}
	}
	void OnTriggerExit(Collider other){
		if ((other.tag == "Switch")) {
			triggerOn = false;
		}
	}
}