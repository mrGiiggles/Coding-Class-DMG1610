using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	//player movement variables
	public float moveSpeed;
	public float jumpHeight;
	private bool doubleJump;

	//player grounded variables
	private bool grounded;
	public Transform groundCheck;
	public float groundCheckRadius;
	public LayerMask whatIsGround;

	//non slide player
	private float moveVelocity;

	// animation variable
	public Animator animator;


	// Use this for initialization
	void Start () {
		// default to true on grounded
		animator = GetComponent<Animator>();
		animator.SetBool("isWalking", false);
		animator.SetBool("isJumping", false);
		
	}

	void FixedUpdate(){
		grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
	}

	//this and && that
	//this or || that
	// !Not
	
	// Update is called once per frame
	void Update () {

		//non-slide PLayer
		moveVelocity = 0f;


		//when ground check collides with ground, sets isJumping as false
		// void OnCollisionEnter2D(Collision2D col){
		// 	if
		// }

		//moves player left & right
		if(Input.GetKey(KeyCode.D)){
			// GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
			moveVelocity = moveSpeed;
			animator.SetBool("isWalking", true);
		}
			//jump released
		else if (Input.GetKeyUp(KeyCode.D)){
			animator.SetBool("isWalking", false);
		}
			
		else if(Input.GetKey(KeyCode.A)){
			// GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
			moveVelocity = -moveSpeed;
			animator.SetBool("isWalking", true);
		}
		else if (Input.GetKeyUp(KeyCode.A)){
			animator.SetBool("isWalking", false);
		}

		GetComponent<Rigidbody2D>().velocity = new Vector2(moveVelocity, GetComponent<Rigidbody2D>().velocity.y);

			//Makes player jump
		if(Input.GetKeyDown(KeyCode.W) && grounded){
			Jump();
			//animator.SetBool("isJumping", true);
		}

		if (grounded) {
			doubleJump = false;
			animator.SetBool("isJumping", false);
		}

		if(Input.GetKey(KeyCode.W)&& !doubleJump && !grounded){
			animator.SetBool("isJumping", true);
			Jump();
			doubleJump = true;
			
		}

		//player flip
		if (GetComponent<Rigidbody2D>().velocity.x > 0)
			transform.localScale = new Vector3(.237f, .237f, .237f);
		else if(GetComponent<Rigidbody2D>().velocity.x < 0)
			transform.localScale = new Vector3(-.237f, .237f, .237f);


	}

	void Jump() {
		GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
		//animator.SetBool("isJumping", true);
	}
}
