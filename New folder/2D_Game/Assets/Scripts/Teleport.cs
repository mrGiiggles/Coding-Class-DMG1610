using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour {

public GameObject gate;
public GameObject player;


private void OnTriggerEnter2D(Collider2D col){
	if (col.gameObject.tag == "Player") {
		StartCoroutine (Yeet());
	}
}

IEnumerator Yeet() {
	yield return new WaitForSeconds(1);
	player.transform.position = new Vector2(gate.transform.position.x, gate.transform.position.y);
	}
	
}
