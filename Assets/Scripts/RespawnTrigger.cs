using UnityEngine;
using System.Collections;

public class RespawnTrigger : MonoBehaviour {

	public	Transform			respawnPoint;
	private	PlayerDeathRespawn	playerDeathRespawn;
	public	ParticleSystem		playerParticles;
	
	// Use this for initialization
	void Start () {
		Transform player 	= GameObject.FindGameObjectWithTag ("Player").GetComponent<Transform> ();
		playerParticles		= player.transform.GetComponentInChildren<ParticleSystem>();
		playerDeathRespawn 	= player.transform.GetComponent<PlayerDeathRespawn> ();
		
	}
	
	void OnTriggerEnter (Collider other) {
		if (other.CompareTag("Player")){
			playerDeathRespawn.currentRespawn = respawnPoint.transform;
			playerParticles.Play();
		}
	}
}