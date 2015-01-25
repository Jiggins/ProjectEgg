using UnityEngine;
using System.Collections;

public class PlayerDeathRespawn : MonoBehaviour {

	[SerializeField]
	public	float				respawnTimeOut	= 2.0f;
	public	Transform			currentRespawn;
	private	Transform			deathPosition;
	public	bool				respawnWithEgg	= false;
	private	Transform			egg;
	private	CharacterMove		characterMove;

	public	CameraController	followCamera;

	// Use this for initialization
	void Start () {
		followCamera 	= GameObject.Find ("Main Camera").GetComponent<CameraController> ();
		deathPosition 	= GameObject.FindGameObjectWithTag ("DeathPosition").GetComponent<Transform> ();
		if(respawnWithEgg){
			egg			= GameObject.FindGameObjectWithTag ("Egg").GetComponent<Transform>();
		}
		characterMove	= GetComponent<CharacterMove>();
	}

	public void Death () {
		transform.rigidbody.useGravity 			= false;
		transform.rigidbody.isKinematic 		= true;
		transform.position 						= deathPosition.position;

		if(respawnWithEgg){
			egg.transform.rigidbody.useGravity	= false;
			egg.transform.rigidbody.isKinematic = true;

			egg.transform.position				= deathPosition.position;
		}

		characterMove.alive						= false;
		followCamera.target						= currentRespawn.transform;

		StartCoroutine (WaitRespawn ());
	}

	IEnumerator WaitRespawn () {
		yield return new WaitForSeconds (respawnTimeOut);
		transform.rigidbody.useGravity 			= true;
		transform.rigidbody.isKinematic 		= false;

		transform.position 						= currentRespawn.position;

		if(respawnWithEgg){
			egg.transform.rigidbody.useGravity	= true;
			egg.transform.rigidbody.isKinematic = false;

			egg.transform.position				= currentRespawn.position;
		}

		characterMove.alive						= true;
		followCamera.target						= transform;
	}
}
