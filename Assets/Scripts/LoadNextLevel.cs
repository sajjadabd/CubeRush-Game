using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadNextLevel : MonoBehaviour {

	public Text level;
	float lastScore;

	public void nextLevel()
	{
		lastScore = FindObjectOfType<PlayerMovement> ().getScore ();

		FindObjectOfType<GameManager> ().setScore (lastScore);

		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
	}

	void Awake()
	{

		level.text = "LEVEL " + (SceneManager.GetActiveScene ().buildIndex + 1);
	}

}
