using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
	public void PlayTheGame()
	{
		SceneManager.LoadScene("Game");
	}

	public void QuitTheGame()
	{
		Debug.Log("QUIT THE GAME");
		Application.Quit();
	}
}
