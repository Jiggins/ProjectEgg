using UnityEngine;
using System.Collections;

public class EggPickup : MonoBehaviour {

	private bool	nearEgg		= false;
	private	bool	pickup 		= false;
	public	bool	holdingEgg 	= false;
	
	private Egg		egg;

	// Use this for initialization
	void Start () {		
		egg 			= GameObject.FindGameObjectWithTag("Egg").GetComponent<Egg>();
	}
	
	// Update is called once per frame
	void Update () {
		pickup 			= Input.GetButtonDown ("Fire1");
	}

	void FixedUpdate () {
		if(pickup & nearEgg){
			if(holdingEgg == false) {
				egg.pickedUp 	= true;
				holdingEgg		= true;
			} else if (holdingEgg){
				egg.pickedUp	= false;
				holdingEgg		= false;
			}
		}
	}

	void OnTriggerEnter (Collider other){
		
		if(other.CompareTag("Egg")) {
			nearEgg = true;
		}
	}
	
	void OnTriggerExit (Collider other) {
		
		if(other.CompareTag("Egg")) {
			nearEgg = false;
		}
	}
}
