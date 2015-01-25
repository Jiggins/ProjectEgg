using UnityEngine;
using System.Collections;

public class DeathTrigger : MonoBehaviour {

	private	PlayerDeathRespawn	playerDeathRespawn;

	// Use this for initialization
	void Start () {
	
		playerDeathRespawn = GameObject.FindGameObjectWithTag ("Player").GetComponent<PlayerDeathRespawn> ();

	}

	void OnTriggerEnter (Collider other) {
		if (other.CompareTag("Player") || other.CompareTag("Egg")){
			playerDeathRespawn.Death();
			Debug.Log ("Lovely particle effects for death!");
		}
	}
}
