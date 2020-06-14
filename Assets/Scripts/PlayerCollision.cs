using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour {
	


	public PlayerMovement movement;


	public GameObject restartPanel;

	public Text text;

	void Awake()
	{
		restartPanel.SetActive (false);
	}

	void OnCollisionEnter(Collision hit)
	{
		if (hit.gameObject.tag == "enemy") {
			
			text.text = "Score : " + FindObjectOfType<PlayerMovement> ().getScore ().ToString("0");


			movement.rigid.velocity = new Vector3 (0, 0, 20);
			movement.enabled = false;

			//FindObjectOfType<GameManager> ().endGame ();


			Invoke ("showRestartPanel", 2f);

		}
	}

	void showRestartPanel()
	{
		restartPanel.SetActive (true);
	}


	void OnTriggerEnter(Collider hit)
	{
		if (hit.gameObject.tag == "end") {
			movement.rigid.velocity = new Vector3 (0, 0, 20);
			movement.enabled = false;

			FindObjectOfType<GameManager> ().CompleteLevel ();
		}

	}
}
