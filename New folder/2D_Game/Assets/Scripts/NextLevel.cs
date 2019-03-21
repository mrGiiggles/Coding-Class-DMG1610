using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour {

	
	public string level;


	private void OnTriggerEnter2D(Collider2D col) {
		switch(col.tag) {
			case "Player":
			SceneManager.LoadScene(level);
			break;
		}
		
			print("This should be working");
		
	
}
}
