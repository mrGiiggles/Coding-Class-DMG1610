using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour {

	private int bottles= 1;
	public bool isRaining = true;

	// Use this for initialization
	void Start () {
		// //for loop
		// for(int i=100; i >= bottles; i++){
		// 	print(i + " bottles of ginger-beer on the wall");
		// }

		while(bottles <= 100){
			//print("It's raining, it's pouring, the old man is snoring!");
			print(bottles + " bottles of ginger-beer on the wall");
			bottles ++;
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
