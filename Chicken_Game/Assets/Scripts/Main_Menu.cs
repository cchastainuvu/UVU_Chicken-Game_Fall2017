using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Main_Menu : MonoBehaviour {

// public string levelToLoad;
// SceneManager.LoadScene(levelToLoad);

//When you do a build, you must have the folder and the executable.
//Add Canvas Scale and scale with screen size.

public int levelToLoad;

public void LoadLevel () {
	SceneManager.LoadScene(levelToLoad);
}

public void LevelExit () {
	Application.Quit();
}

}
