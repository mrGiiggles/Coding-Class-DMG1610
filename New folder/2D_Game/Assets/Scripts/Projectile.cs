using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

	public float speed;

	public float timeOut;
	public GameObject player;

	public GameObject enemyDeath;

	public GameObject projectileParticle;

	public int pointsForKill;

	// Use this for initialization
	void Start () {
		player = GameObject.Find("Player");

		enemyDeath = Resources.Load("Prefabs/deathParticle") as GameObject;

		projectileParticle = Resources.Load("Prefabs/deathParticle") as GameObject;

		if (player.transform.localScale.x < 0)
		speed = -speed;

		//destroy projectile after x seconds
		Destroy(gameObject,timeOut);
		
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody2D>().velocity = new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y);
	}

	void OnTriggerEnter2D(Collider2D col) {
		//Destroys enemy on contact with projectile. Adds points
		if (col.tag == "Enemy") {
			Instantiate(enemyDeath, col.transform.position, col.transform.rotation);
			Destroy(col.gameObject);
			ScoreManager.AddPoints (pointsForKill);
		}
	//instantiate(projectileParticle, transform.position, transform.rotation);
	//destroys the projectile after impact with enemy
		Destroy(gameObject);
	}

	//OnColission with object in the envoronment
	void OnCollisionEnter2D(Collision2D col) {
		Instantiate(projectileParticle, transform.position, transform.rotation);
		Destroy(gameObject);
	}
}
