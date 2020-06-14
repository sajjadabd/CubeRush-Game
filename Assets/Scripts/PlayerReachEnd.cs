using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerReachEnd : MonoBehaviour {

	public GameObject guide;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnTriggerEnter(Collider hit)
	{
		if (hit.gameObject.tag == "Player") {
			guide.SetActive (false);
		}
	}
}
