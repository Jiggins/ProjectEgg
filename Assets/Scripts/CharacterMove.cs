using UnityEngine;
using System.Collections;

public class CharacterMove : MonoBehaviour {
	public float speed = 1.0f;
	public	float	jumpHeight = 1.0f;
	private Vector3 movement;

	public	Collider	eggCollider;

	public	Animator	animator;

	
	private Rigidbody playerRigidbody;
	[SerializeField]
	private	LayerMask floorMask;
	[SerializeField]
	private float	groundedRayLength;
	[SerializeField]
	private	Vector3	orientateLeft;
	[SerializeField]
	private	Vector3	orientateRight;
	
	private	float	distToGround;

	public	bool	alive = true;
	
	void Awake () {
		playerRigidbody = GetComponent<Rigidbody> ();
		
		distToGround 	= collider.bounds.extents.y;

		animator 		= GetComponentInChildren<Animator>();
	}

	void Start () {
		Physics.IgnoreCollision (eggCollider, transform.collider);
	}

	void Update () { 
	}
	
	void FixedUpdate() {
		// Store the input axes.
		float h 		= Input.GetAxisRaw ("Horizontal");
		
		bool jump 		= Input.GetButton ("Jump");

		if (Input.GetButtonDown("Fire2")) {
			Application.LoadLevel("LevelTwo");
		}

		if (Input.GetButtonDown("Fire3")) {
			Application.LoadLevel("LevelThree");
		}


		
		// Move the player around the scene.
		Move (h, jump);
		
		Turning (h);
	}
	
	void Move (float h, bool jump) {
		if(alive){
			// Set the movement vector based on the axis input.
			movement.Set (h, 0.0f, 0.0f);
			
			// Normalise the movement vector and make it proportional to the speed per second.
			movement = movement.normalized * speed * Time.deltaTime;

			bool grounded = IsGrounded();

			
			if(jump && IsGrounded()){

				rigidbody.AddForce(new Vector3(0.0f,jumpHeight,0.0f), ForceMode.Impulse);
			}

			if (grounded) {
				animator.SetBool("jumping", false);
			}else{
				animator.SetBool("jumping", true);
			}
			
			animator.SetFloat("walkSpeed", Mathf.Abs(h));

			
			// Move the player to it's current position plus the movement.
			playerRigidbody.MovePosition (transform.position + movement);
		}
	}
	
	void Turning (float h) {
		if(h > 0.1f){
			
			playerRigidbody.MoveRotation(Quaternion.Euler(orientateRight));
		}
		if(h < -0.1f){
			
			playerRigidbody.MoveRotation(Quaternion.Euler(orientateLeft));
		}
	}
	
	// Raycast under the player to detect if he is grounded
	private bool IsGrounded()
	{
		return Physics.Raycast(transform.position, -Vector3.up, distToGround + 0.1f);
	}
}