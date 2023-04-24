﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinScript : MonoBehaviour {

	public AudioSource coinSound;
	public static int coins;
	public Text Coins;


	public void OnTriggerEnter(Collider Col)
	{
		if(Col.gameObject.tag == "Coin")
		{
			Debug.Log("Coin work");
			coins = coins + 1;
			Col.gameObject.SetActive(false);
			Destroy(Col.gameObject);
			coinSound.Play();
		}
	}
	void Update()
	{
		Coins.text = "Score: " + coins;
	}

	/*private void OnTriggerEnter(Collider other){
		if (other.name == "Player") {
			//other.GetComponent<PlayerScriptPoints> ().points++;
			Destroy (gameObject);
			coinSound.Play();
		}
	}*/
		/*void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Player") {
			Destroy (gameObject);
			coinSound.Play();
		}
	}*/
}