using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour {

	//AudioSource audio;

	static float Score = 0;
	float temp;

	public Rigidbody rigid;
	public Text text;
	float zSpeed = 50f;
	float xSpeed = 15f;

	bool AndroidRight = false;
	bool AndroidLeft = false;

	bool grounded = false;

	bool itIsAndroid = false;

	float lastScore;

	//bool AndroidAudio = false;

	public void resetScore()
	{
		Score = 0;
	}

	void Awake()
	{
		//audio = GetComponent<AudioSource> ();


	}

	public float getScore()
	{
		return Score;
	}

	// Use this for initialization
	void Start () {
		//Time.timeScale = 1;
		lastScore = FindObjectOfType<GameManager> ().getLastScore ();
		if ( lastScore != 0) {
			Score = lastScore;
		}


	}
	
	// Update is called once per frame
	void Update()
	{
		//Android

		#if UNITY_ANDROID

		if (Input.touchCount > 0) {
			
			Touch touch = Input.GetTouch (0);

			if (touch.position.x < Screen.width/2  && grounded) {
				AndroidLeft = true;
				AndroidRight = false;
				rigid.velocity = new Vector3 (-xSpeed, rigid.velocity.y, zSpeed);
			} else if (touch.position.x >= Screen.width/2  && grounded) {
				AndroidRight = true;
				AndroidLeft = false;
				rigid.velocity = new Vector3 (xSpeed, rigid.velocity.y, zSpeed);
			} else {
				AndroidRight = false;
				AndroidLeft = false;
				rigid.velocity = new Vector3 (0, rigid.velocity.y, zSpeed);
			}

			itIsAndroid = true;

		}

		if ( AndroidRight )
		{

		}
		else if ( AndroidLeft )
		{

		}
		else
		{


		}
		#endif


		#if UNITY_EDITOR

		// PC
		if (Input.GetKey (KeyCode.A) && grounded) {
			rigid.velocity = new Vector3 (-xSpeed, rigid.velocity.y, zSpeed);
		}
		else if (Input.GetKey (KeyCode.D)  && grounded) {
			rigid.velocity = new Vector3 (xSpeed, rigid.velocity.y, zSpeed);
		} else {
			rigid.velocity = new Vector3 (0, rigid.velocity.y, zSpeed);
		}

		//Score ++;
		Score = transform.position.z;

		#endif

		if (transform.position.y < -0.5f) {
			grounded = false;
		}

		if (transform.position.y < -2) {
			//SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
			FindObjectOfType<GameManager>().endGame();
		}

		//text.text = transform.position.z.ToString ("0");
		//temp = transform.position.z;

		if (itIsAndroid) {

			//Score++;
			Score = transform.position.z;

		}

		text.text = Score.ToString ("0");


	}


	void FixedUpdate () {
		
	}


	void OnCollisionEnter(Collision hit)
	{
		if (hit.gameObject.tag == "ground") {
			grounded = true;
		}
	}
}
