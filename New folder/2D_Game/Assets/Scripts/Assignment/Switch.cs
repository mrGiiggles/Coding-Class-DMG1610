using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour {
	public string suspect;
	public string weapon;

	// Use this for initialization
	void Start () {
		MurderMystery(suspect);
	}
	
	
	void MurderMystery (string person){
		switch(person){
			case "Mr. Ketchup":
				//print("I was in the Pool room, smoking and shooting with Mr. Radish");
			//break;
			case "Mr. Radish":
				print("I was ejoying the evening in the Billiard Room.");
			break;
			case "Ms. Frysause":
			    print("I was talking on the rotary phone with my mother, Mrs. Mayo");
			break;
			case "Mrs. Mayo":
				print("I was in the kitcken cleaning up the dishes with the scrubber");
			break;
			default:
				print("I am not familiar with " +suspect+" !");
			break;

		}


	}
	}


