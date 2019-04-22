using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {
	public Transform firePoint;
	public GameObject projectile;
	public Animator animator;

	// Use this for initialization
	void Start () {
		//load pojettile from resources/prefabs folder
		projectile = Resources.Load("Prefabs/Projectile") as GameObject;
		animator = GetComponent<Animator>();
		animator.SetBool("isSpitting", false);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.RightControl)) {
		Instantiate(projectile, firePoint.position, firePoint.rotation);
		animator.SetBool("isSpitting", true);
	}
	else if (Input.GetKeyUp(KeyCode.RightControl)) {
		animator.SetBool("isSpitting", false);
	}
	}

}
