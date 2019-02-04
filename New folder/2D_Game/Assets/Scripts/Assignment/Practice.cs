using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practice : MonoBehaviour {
	public string pizza;
	

	void Start() {
		PizzaTime(pizza);

	}

	void PizzaTime(string brand) {
		if (brand == "Pizza Hut") {
			print("Not a bad choice.");
		}
		else if (brand == "Dominos") {
			print("I don't know why, but OK");
		}
		else if (brand == "Best Pizza") {
			print("How did you get to New York?!");
		}
		else if (brand == "Little Ceasers") {
			print("Risky there, i like your style.");
		}
		else if (brand == "Brick Oven"){
			print("Excellent choice, no complaint here");
		}
		else {
			print("Dood, " + brand + " is one BAD choice.");
		}

	}

	
	
}
