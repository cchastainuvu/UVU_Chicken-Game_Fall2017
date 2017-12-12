using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tutorial : MonoBehaviour {

public int levelToLoad;

public void LoadLevel () {
	SceneManager.LoadScene(2);
}

public void LevelExit () {
	Application.Quit();
}
}
