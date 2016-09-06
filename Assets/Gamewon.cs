﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gamewon : MonoBehaviour {

	public Text FinishText;
	private bool finishCheck = false;

	void OnTriggerEnter(Collider col)
	{
		if (col.tag == "Player") {
			FinishText.text = "You have passed the level!" +
			"\n" +
			"Press R to restart the level.";
			finishCheck = true;

		}

	}
	void Update(){

		if (finishCheck && Input.GetKeyDown(KeyCode.R)) {
			FinishText.text = "";
			finishCheck = false;
			Destroy (gameObject);
			SceneManager.LoadScene ("DemoLevel");
		}

	}


}
