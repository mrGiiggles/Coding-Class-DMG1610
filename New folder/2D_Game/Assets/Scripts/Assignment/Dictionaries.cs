using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dictionaries : MonoBehaviour {

	public Hashtable starWarsDoods = new Hashtable();

	// Use this for initialization
	void Start () {

		starWarsDoods.Add("Name", " Han Solo,");
		starWarsDoods.Add("Occupation", " Varies");
		starWarsDoods.Add("Skills", "Marksman, Pilot");
		starWarsDoods.Add("Alive", " False");
		
		print((string)starWarsDoods["Name"]);
	}
	

}
