using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackgroundMusic : MonoBehaviour {

	//AudioSource audio;
	// Use this for initialization
	void Start () {
		//audio = GetComponent<AudioSource> ();
		//Invoke ("play", 2f);
		DontDestroyOnLoad (this.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		/*
		switch (SceneManager.GetActiveScene ().buildIndex) {
		case 0:
			audio.volume = 0.1f;
			break;
		case 1:
			audio.volume = 0.2f;
			break;
		case 2:
			audio.volume = 0.3f;
			break;
		case 3:
			audio.volume = 0.4f;
			break;
		case 4:
			audio.volume = 0.5f;
			break;
		case 5:
			audio.volume = 0.6f;
			break;
		case 6:
			audio.volume = 0.7f;
			break;
		case 7:
			audio.volume = 0.8f;
			break;
		default:
			audio.volume = 0.9f;
			break;
		}
		*/
	}

	void play()
	{
		//audio.Play ();
	}
}
