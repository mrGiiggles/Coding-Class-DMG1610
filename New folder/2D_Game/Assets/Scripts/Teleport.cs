using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour {

public GameObject gate;
public GameObject player;
public GameObject exitPoint;


private void OnTriggerEnter2D(Collider2D col){
	if (col.gameObject.tag == "Player") {
		StartCoroutine (Yeet());
	}
}

IEnumerator Yeet() {
	yield return new WaitForSeconds(1);
	player.transform.position = new Vector2(exitPoint.transform.position.x, exitPoint.transform.position.y);
	}
	
}
