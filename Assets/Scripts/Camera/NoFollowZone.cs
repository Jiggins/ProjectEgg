using UnityEngine;
using System.Collections;

public class NoFollowZone : MonoBehaviour {

	void OnTriggerEnter(Collider colide) {
		if (colide.gameObject.tag == "Player") {
					
			CameraController temp = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraController>();
			temp.canMove = false;
			}
	}

	void OnTriggerExit(Collider colide) {
		if (colide.gameObject.tag == "Player") {
			
			CameraController temp = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraController>();
			temp.canMove = true;
		}
	}
}
