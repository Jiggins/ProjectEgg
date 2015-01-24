using UnityEngine;
using System.Collections;

public class PlayerPlatformInteract : MonoBehaviour {
	public float speed;
	public float distance;
	public GameObject trig;

	// Use this for initialization
	void Start () {
			
	}
	
	// Update is called once per frame
	void Update () {

	
	}
	void OnTriggerEnter (Collider other) { 
		if(other.gameObject.tag == "Player") { 
			other.transform.parent = transform; 
		} 
	}
	
	void OnTriggerExit (Collider other) { 
		if(other.gameObject.tag == "Player") { 
			other.transform.parent = null; 
		} 
	}
}

