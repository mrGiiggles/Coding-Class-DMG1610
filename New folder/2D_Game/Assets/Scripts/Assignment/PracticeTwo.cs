using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeTwo : MonoBehaviour {
public string genre;

public Start() {
    Library(genre);
}

Library(string book) {
    if ( book == "Horror") {
        StephenKing();
    }
    else if (book == "Fantasy") {
        JRRTolkien();

    }
    else if (book == "Scifi") {
        OrsonCard();
    }
    else if(book == "Romance") {
        JohnGreen();
    }
    else{
        Browser();
    }
}

StephenKing() {
    print("Stephen King is a good place to start. Or so I hear.");
}

JRRTolkien() {
    print("Tolkien is good, Terry Pratchett too. Oh, and Christopher Paolini");
}

JohnGreen() {
    print("John Green, Nicholas Spark and Joanna Flukke. Now get out of my face.");
}

Browser() {
    print("Try looking around. You'll find something that'll jump out at you. Just avoid the supernatual section.");
}

}