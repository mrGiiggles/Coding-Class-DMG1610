using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IF_Pasta : MonoBehaviour {

	public string pasta;
	public bool waterBoil = true;
    public string sauce;

	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (pasta == "Soft") {
            if (waterBoil) {
                print("Pasta is ready to eat!!");
            }
        }
        else if (pasta == "Hard" && waterBoil == false) {
            print("Well, get your water boiling first");
        }
        else if (pasta == "Hard" && waterBoil) {
            print("Throw your noodles in!");
        }
        else if (pasta == "Softer" && waterBoil == false) {
            print("How in the world . . .");
        }
        else if (pasta == "Cooked" && sauce == "Red") {
            print("Say goodbye to that white shirt dood.");
        }
        else if (pasta == "Cooked" && sauce == "White") {
            print("Ahh, classic. I like your taste.");
        }
        else if (pasta == "Cooked" && sauce == "Alfredo") {
            print("Fine taste you have sir. Whine menue?");
        }
        else if (pasta == "Cooked" && sauce == "Mayo") {
            print("Get out. NOW!");
        }
        else if (pasta == "Cooked" && sauce == "Stroganaff") {
            print("Right away sir.");
        }
        else {
            print("You don't know how to cook, do you??");
        }
    }
}
