using UnityEngine;
using System.Collections;

public class TriggerScript : MonoBehaviour {
	public float trigCount      = 0;
	public bool triggerOn        = false;
	public bool triggerOnPerm    = false;
	public bool triggerOnPermFin = false;
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
		if ((other.tag == "SwitchPerm")) {
			triggerOnPerm = true;
		}
		if ((other.tag == "SwitchPermFin")) {
			triggerOnPermFin = true;
			trigCount++;
		}
	}

	void OnTriggerExit(Collider other){
		if ((other.tag == "Switch")) {
			triggerOn = false;
		}
	}

}