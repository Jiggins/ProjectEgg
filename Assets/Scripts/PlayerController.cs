using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{
	public float Speed = 0f;
	private float moveHorizontal = 0f;
	private float moveVertical = 0f;
	public float jump = 0f;
	private bool airbourne = true;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		
		//Horizaontal Movement
		moveHorizontal = Input.GetAxis ("Horizontal");
		Vector3 movement = new Vector3 (moveHorizontal * Speed, moveVertical * Speed, 0f);
		rigidbody.MovePosition (rigidbody.position + movement * Time.deltaTime);
		
		//Jumping
		if (!airbourne) 
		{
			if (Input.GetButtonDown ("Fire1") || Input.GetButtonDown("Jump")) {
				rigidbody.AddForce (Vector3.up * jump * Time.deltaTime);
				airbourne = true;
			}
		}
	}
	
	//Reset the airbourne bool
	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Floor") {
			airbourne = false;
		}
	}
}
