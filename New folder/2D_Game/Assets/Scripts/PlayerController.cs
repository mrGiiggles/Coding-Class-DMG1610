using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	//player movement variables
	public float moveSpeed;
	public float jumpHeight;

	//player grounded variables
	private bool grounded;


	// Use this for initialization
	void Start () {
		// default to true on grounded
		grounded = true;
		
	}

	//this and && that
	//this or || that
	// !Not
	
	// Update is called once per frame
	void Update () {
		//moves player left & right
		if(Input.GetKey(KeyCode.D)){
			GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
		}

		else if(Input.GetKey(KeyCode.A)){
			GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
		}
			
			//Makes player jump
		if(Input.GetKeyDown(KeyCode.W) && grounded){
			GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
		}
	}
}
