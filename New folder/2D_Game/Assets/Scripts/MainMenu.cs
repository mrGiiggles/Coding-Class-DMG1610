﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
//index level to load
public int levelToLoad;
//this function loads the level stored in the levelToLoad variable after button is pressed
public void LoadLevel() {
	SceneManager.LoadScene(levelToLoad);
}
//this function quits the game after the button is pressed
 public void LevelExit() {
	 Application.Quit();
 }
}
