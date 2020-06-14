using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {


	///public GameObject Tapsell;
	static float lastScore = 0;
	bool gameOver = false;

	public GameObject levelCompletePanel;

	void Awake()
	{
		levelCompletePanel.SetActive (false);
	}

	public void setScore(float f)
	{
		lastScore = f;
	}

	public float getLastScore()
	{
		return lastScore;
	}

	public void endGame()
	{
		if (gameOver == false) {
			
			//Time.timeScale = .5f;
			//lastScore = FindObjectOfType<PlayerMovement> ().getScore ();
			Invoke ("end", 2f);
			//print ("Game Over");

			gameOver = true;
		}

	}

	public void CompleteLevel()
	{
		levelCompletePanel.SetActive (true);
		//endGame ();
	}


	public void restartLevel()
	{
		//GameObject.FindGameObjectsWithTag ("Tapsell").sendRequest ();

		//Tapsell.GetComponent<Test>().sendRequest();
		//Tapsell.GetComponent<Test>().ShowAd();
		end ();
	}

	public void end()
	{

		FindObjectOfType<PlayerMovement> ().resetScore ();
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
	}

	public void exit()
	{
		Application.Quit ();
	}

}
