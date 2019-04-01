using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill : MonoBehaviour {

	public LevelManager levelManager;

//for initializing
	void Start() {
		levelManager = FindObjectOfType <LevelManager>();
	}

	void OnTriggerEnter2D(Collider2D col) {
		if(col.name == "Player") {
			levelManager.RespawnPlayer();
		}
	}
	
}
