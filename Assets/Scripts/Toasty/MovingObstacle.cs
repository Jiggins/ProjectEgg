using UnityEngine;
using System.Collections;

public class MovingObstacle : MonoBehaviour {
	
	
	public float speed = 0.01f;
	public Vector3 distance;
	private Vector3 startPosition;
	private Vector3 endPosition;
	private bool forward;
	
	// Use this for initialization
	void Start () {
		startPosition = transform.position;
		endPosition= distance + startPosition;

	}
	
	// Update is called once per frame
	void Update () {
		
		if(transform.position == startPosition){
			forward = true;
		}else if (transform.position == endPosition){
			forward = false;
		}
		
		
		if(forward){
			transform.position = Vector3.MoveTowards(transform.position, endPosition, speed);
		}
		else {
			transform.position = Vector3.MoveTowards(transform.position, startPosition, speed);
		}
		
	}


	void OnCollisionStay(Collision collision){

		if (collision.gameObject.tag == "Player"){

			Vector3 trans = collision.transform.position;

			trans.x = transform.position.x;
			collision.transform.position = trans;

		}

	}
}
