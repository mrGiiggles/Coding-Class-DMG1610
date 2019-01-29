using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour {

	 public static int number;
	 public float speed;
	 public string name;

	// Use this for initialization
        /*multi
		line
		comment
		dood
		 */
	void Start () {
		//?number = 10;
		speed = 1.84f;
		name = "Bob";

		print(name + " was " +number+ " years old!!" + speed);
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (number,0,0);
		
	}
}
