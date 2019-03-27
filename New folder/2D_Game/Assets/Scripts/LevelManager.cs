﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public GameObject currentCheckPoint;
	private Rigidbody2D pcRigid;

	private GameObject player;
	
	//particles;
	public GameObject deathParticle;
	public GameObject respawnParticles;

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
	
	// Update is called once per frame
	void Update () {
		
	}
}
