using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : GenericPickup {

	public GameObject PC;

	void onTriggerEnter2D(collider2D other){
		if(GameObject.other.name == "PC") {
			//player collect coin
		}

		else{
			//not [layer]
		}

	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
