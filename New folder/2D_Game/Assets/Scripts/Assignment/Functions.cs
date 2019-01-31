using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour {

	public string weather;

	void Start(){

		Weather(weather);
	}

	void Weather(string weatherState) {

		if(weatherState == "Sunny") {
			print("The sun is shining today!");
		}

		else if(weatherState == "Raining"){
			print("It is soggy and wet today!");
		}

		else if(weatherState == "Windy"){
			print("It is blowing like a Zephyr today!");
		}

		else if(weatherState == "Snowing"){
			print("It is blizzard out there!");
		}

		else if(weatherState == "Foggy"){
			print("Visiblitly is more poor than me.");
		}
		else{
			print("I don't understand" +weatherState);
		}

	}

}
