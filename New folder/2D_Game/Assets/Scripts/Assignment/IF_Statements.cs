using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IF_Statements : MonoBehaviour {

	public string stopLight;
	public bool isUtahn = true;

	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(stopLight == "Red") {
			if(isUtahn){
			print("Stop! The Light is RED!");
			}
			else{
				print("Thanks for stopping and not killing anyone.");
			}
		}
		else if(stopLight == "Yellow") {
			if(isUtahn){
			print("Hurry, you got this!");
			}
			else{
				print("Thanks for preparing to stop.");
			}
		}
		else if(stopLight == "Green") {
			if(isUtahn){
			print("Leave Already!");
			}
			else{
				print("Thanks for having common sense.");
			}
		}
		else {
			print("Apologies, you're driving in Utah.");
		}
		
	}
}
