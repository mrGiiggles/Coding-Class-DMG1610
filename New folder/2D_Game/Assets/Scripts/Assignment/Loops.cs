using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour {

//	private int bottles= 1;
//	public bool isRaining = true;

	// Use this for initialization
	void Start () {
		// //for loop
		// for(int i=100; i >= bottles; i++){
		// 	print(i + " bottles of ginger-beer on the wall");


		//practice loop
		// for (int i = 20; i<=20; i--) {
		// 	print(i);
		// 	switch () {
		// 		case i = 0:
		// 		print("Ready or not, here i come!");
		// 		break;
		// 		default:
			
		// 	}
		// }
		 


		// while(bottles <= 100){
		// 	//print("It's raining, it's pouring, the old man is snoring!");
		// 	print(bottles + " bottles of ginger-beer on the wall");
		// 	bottles ++;
		// }


		//DO WHILE LOOP
		// bool shouldContinue = false;

		// do {
		// 	print("Hello World");
		// } while (shouldContinue == true);

		//FOR EACH LOOP, PERFECT FOR ITERATING THROUGH AN ARRAY
		string [] strings = new string [3];

		strings[0] = "First String";
		strings[1] = "Second String";
		strings[2] = "Third String";

		foreach(string item in strings)
		{
			print (item);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}


