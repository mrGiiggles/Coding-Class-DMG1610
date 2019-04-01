using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public GameObject currentCheckPoint;
	private Rigidbody2D pcRigid;

	private GameObject player;
	
	//particles;
	public GameObject deathParticle;
	public GameObject respawnParticle;

	//respawn delay
	public float respawnDelay;

	//points penalty on death
	public int pointPenaltyOnDeath;

	//store gravity value
	private float gravityStore;

	// Use this for initialization
	void Start () {
		pcRigid = GameObject.Find("Player").GetComponent<Rigidbody2D>();
		player = GameObject.Find("Player");
		
	}

	public void RespawnPlayer() {
		StartCoroutine ("RespawnPlayerCo");
	}
	
	public IEnumerator RespawnPlayerCo() {
		//generate death particle
		Instantiate (deathParticle, pcRigid.transform.position, pcRigid.transform.rotation);
		//Hide pcRigid
	player.SetActive(false);
	player.GetComponent<Renderer>().enabled = false;
	//gravity reset
	gravityStore = pcRigid.GetComponent<Rigidbody2D>().gravityScale;
	pcRigid.GetComponent<Rigidbody2D>().gravityScale = 0f;
	pcRigid.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
	//Point Penalty
	ScoreManager.AddPoints(-pointPenaltyOnDeath);
	//debug message
	Debug.Log ("PC Respawn");
	//respawn delay, can't use waitforseconds in an update cycle
	yield return new WaitForSeconds (respawnDelay);
	//Gravity restore
	pcRigid.GetComponent<Rigidbody2D>().gravityScale = gravityStore;
	//Match pcRigid transform position
	pcRigid.transform.position = currentCheckPoint.transform.position;
	//show pcRigid
	player.SetActive(true);
	player.GetComponent<Renderer> ().enabled = true;
	//Spawn pcRigid
	Instantiate (respawnParticle, currentCheckPoint.transform.position, currentCheckPoint.transform.rotation);


	}
	
}
