using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour {
	public string film

	// Use this for initialization
	void Start () {
		Cinema(film);
	}
	
	
	void Cinema (string movie){
		switch(movie){
            case "Pen Pal":
            case "All isn't fair.":
                print("Looks like its a romance night for you bud.");
            break;
            case "Peter Pot":
                print("Comedy knock off? Your buck you're wasting pal");
            break;
			case "Blood Hungry":
                print("As Horror goes, not bad.");
            break;
            case "The Zodiacs":
                print("Surprise they have an anime film");
            break;
            case "Kn'ex":
            case "My Semi-big Pony":
                print("Kids choice night?");
            break;

		}


	}
	}

