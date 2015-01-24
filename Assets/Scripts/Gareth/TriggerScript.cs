using UnityEngine;
using System.Collections;

public class TriggerScript : MonoBehaviour {

	public bool triggerOn = false;
	public bool triggerOnPerm = false;
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
		else if ((other.tag == "SwitchPerm")) {
			triggerOnPerm = true;
		}
	}
	void OnTriggerExit(Collider other){
		if ((other.tag == "Switch")) {
			triggerOn = false;
		}
	}

}