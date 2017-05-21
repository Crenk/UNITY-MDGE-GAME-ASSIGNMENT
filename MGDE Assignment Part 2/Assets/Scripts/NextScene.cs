using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour {

    public int lvlNum;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }

    public void ToRulesScene()
    {
        Application.LoadLevel("Rules");
    }

    public void ToCreditsScene()
    {
        Application.LoadLevel("Credits");
    }

    public void ToQuit()
    {
        Application.Quit();
    }

    public void ToGameScene()
    {
        Application.LoadLevel("Level 1");
    }

    public void BackToGameMenu()
    {
        Application.LoadLevel("Main Menu");
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void restartEntireGame()
    {
        Application.LoadLevel("Level 1");
    }
}
