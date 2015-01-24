using UnityEngine;
using System.Collections;

public class MovingPlatform : MonoBehaviour {
	
	
	public float speed;
	public Vector3 distance;
	private Vector3 startPosition;
	private Vector3 endPosition;
	private bool forward = true;
	private float startTime;
	private float journeyLength;
	
	// Use this for initialization
	void Start () {
		startTime = Time.time;

		startPosition = transform.position;
		endPosition= distance + startPosition;
		journeyLength = Vector3.Distance(startPosition, endPosition);
	}
	
	// Update is called once per frame
	void Update () {
		float distCovered = (Time.time - startTime) * speed;
		if(transform.position == startPosition){
			forward = true;
			startTime = Time.time;
		}else if (transform.position == endPosition){
			forward = false;
			startTime = Time.time;
		}


		float fracJourney = distCovered / journeyLength;
		

		
		
		if(forward){
			transform.position = Vector3.Lerp(transform.position, endPosition, fracJourney);		}
		else {
			transform.position = Vector3.Lerp(transform.position, startPosition, fracJourney);
		}
		
	}
}
