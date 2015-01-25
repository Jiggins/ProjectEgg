using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
	
	// public GameObject player;
	public float smoothTime = 0.7f;
	private Vector3 velocity = Vector3.zero;
	public Transform target;
	public bool canMove = true;


	// Update is called once per frame
	void LateUpdate () {
		if (canMove) {
			Vector3 point = camera.WorldToViewportPoint (target.position);
			Vector3 delta = target.position - camera.ViewportToWorldPoint (new Vector3 (0.5f, 0.5f, point.z));

			Vector3 destination = transform.position + delta;
			transform.position = Vector3.SmoothDamp (transform.position, destination, ref velocity, smoothTime);
		}
	}

	public void SetAbilityToMove(bool move) {
		this.canMove = move;
	}
}