﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Linq;
using System.Collections.Generic;

public class ScoreCheck : MonoBehaviour {

	public List<int> scores = new List<int>();
	public Transform p1FirstPlace;
	public Transform p1SecondPlace;
	public Transform p1ThirdPlace;
	public Transform p1FourthPlace;
	public Transform p2FirstPlace;
	public Transform p2SecondPlace;
	public Transform p2ThirdPlace;
	public Transform p2FourthPlace;
	public Transform p3FirstPlace;
	public Transform p3SecondPlace;
	public Transform p3ThirdPlace;
	public Transform p3FourthPlace;
	public Transform p4FirstPlace;
	public Transform p4SecondPlace;
	public Transform p4ThirdPlace;
	public Transform p4FourthPlace;
	public GameObject p1;
	public GameObject p2;
	public GameObject p3;
	public GameObject p4;
	public GameObject p1Score;
	public GameObject p2Score;
	public GameObject p3Score;
	public GameObject p4Score;
	public Text firstPlace;
	public Text secondPlace;
	public Text thirdPlace;
	public Text fourthPlace;
	public GameObject firstPlaceSprite;
	public GameObject secondPlaceSprite;
	public GameObject thirdPlaceSprite;
	public GameObject fourthPlaceSprite;
	public Sprite adventurer;
	public Sprite wizard;
	public Sprite knight;
	public Sprite pirate;
	public GameObject exit;
	public float speed;

	private GameObject timer;
	// Use this for initialization
	void Start () {
		timer = GameObject.Find ("transition");
	}


	
	// Update is called once per frame
	void FixedUpdate () {
		int first;
		int second;
		int third;
		int fourth;
		int player1Score = ScoreSystem.Instance.player1Score;
		int player2Score = ScoreSystem.Instance.player2Score;
		int player3Score = ScoreSystem.Instance.player3Score;
		int player4Score = ScoreSystem.Instance.player4Score;
		scores.Add (player1Score);
		scores.Add (player2Score);
		scores.Add (player3Score);
		scores.Add (player4Score);
		first = scores.Max ();
		fourth = scores.Min ();
		scores.Remove (scores.Max ());
		scores.Remove (scores.Min ());
		second = scores.Max ();
		third = scores.Min ();

		if(SceneManager.GetActiveScene().name == "PlayerStanding"){
			//player1
			if (player1Score == first) {
				p1.transform.position = Vector3.MoveTowards(p1.transform.position, p1FirstPlace.position,(speed*Time.deltaTime));
			} else if (player1Score == second) {
				p1.transform.position = Vector3.MoveTowards(p1.transform.position, p1SecondPlace.position,(speed*Time.deltaTime));
			} else if (player1Score == third) {
				p1.transform.position = Vector3.MoveTowards(p1.transform.position, p1ThirdPlace.position,(speed*Time.deltaTime));
			} else {
				p1.transform.position = Vector3.MoveTowards(p1.transform.position, p1FourthPlace.position,(speed*Time.deltaTime));
			}
			//player2
			if (player2Score == first) {
				p2.transform.position = Vector3.MoveTowards(p2.transform.position, p2FirstPlace.position,(speed*Time.deltaTime));
			} else if (player2Score == second) {
				p2.transform.position = Vector3.MoveTowards(p2.transform.position, p2SecondPlace.position,(speed*Time.deltaTime));
			} else if (player2Score == third) {
				p2.transform.position = Vector3.MoveTowards(p2.transform.position, p2ThirdPlace.position,(speed*Time.deltaTime));
			} else {
				p2.transform.position = Vector3.MoveTowards(p2.transform.position, p2FourthPlace.position,(speed*Time.deltaTime));
			}
			//player3
			if (player3Score == first) {
				p3.transform.position = Vector3.MoveTowards(p3.transform.position, p3FirstPlace.position,(speed*Time.deltaTime));
			} else if (player3Score == second) {
				p3.transform.position = Vector3.MoveTowards(p3.transform.position, p3SecondPlace.position,(speed*Time.deltaTime));
			} else if (player3Score == third) {
				p3.transform.position = Vector3.MoveTowards(p3.transform.position, p3ThirdPlace.position,(speed*Time.deltaTime));
			} else {
				p3.transform.position = Vector3.MoveTowards(p3.transform.position, p3FourthPlace.position,(speed*Time.deltaTime));
			}
			//player4
			if (player4Score == first) {
				p4.transform.position = Vector3.MoveTowards(p4.transform.position, p4FirstPlace.position,(speed*Time.deltaTime));
			} else if (player4Score == second) {
				p4.transform.position = Vector3.MoveTowards(p4.transform.position, p4SecondPlace.position,(speed*Time.deltaTime));
			} else if (player4Score == third) {
				p4.transform.position = Vector3.MoveTowards(p4.transform.position, p4ThirdPlace.position,(speed*Time.deltaTime));
			} else {
				p4.transform.position = Vector3.MoveTowards(p4.transform.position, p4FourthPlace.position,(speed*Time.deltaTime));
			}
		}else{
			//player1
			if (player1Score == first) {
				firstPlaceSprite.GetComponent<Image>().sprite = adventurer;
				firstPlace.text = player1Score+" Points";
			} else if (player1Score == second) {
				secondPlaceSprite.GetComponent<Image>().sprite = adventurer;
				secondPlace.text = player1Score+" Points";
			} else if (player1Score == third) {
				thirdPlaceSprite.GetComponent<Image>().sprite = adventurer;
				thirdPlace.text = player1Score+" Points";
			} else {
				fourthPlaceSprite.GetComponent<Image>().sprite = adventurer;
				fourthPlace.text = player1Score+" Points";
			}
			//player2
			if (player2Score == first) {
				firstPlaceSprite.GetComponent<Image>().sprite = wizard;
				firstPlace.text = player2Score+" Points";
			} else if (player2Score == second) {
				secondPlaceSprite.GetComponent<Image>().sprite = wizard;
				secondPlace.text = player2Score+" Points";
			} else if (player2Score == third) {
				thirdPlaceSprite.GetComponent<Image>().sprite = wizard;
				thirdPlace.text = player2Score+" Points";
			} else {
				fourthPlaceSprite.GetComponent<Image>().sprite = wizard;
				fourthPlace.text = player2Score+" Points";
			}
			//player3
			if (player3Score == first) {
				firstPlaceSprite.GetComponent<Image>().sprite = knight;
				firstPlace.text = player3Score+" Points";
			} else if (player3Score == second) {
				secondPlaceSprite.GetComponent<Image>().sprite = knight;
				secondPlace.text = player3Score+" Points";
			} else if (player3Score == third) {
				thirdPlaceSprite.GetComponent<Image>().sprite = knight;
				thirdPlace.text = player3Score+" Points";
			} else {
				fourthPlaceSprite.GetComponent<Image>().sprite = knight;
				fourthPlace.text = player3Score+" Points";
			}
			//player4
			if (player4Score == first) {
				firstPlaceSprite.GetComponent<Image>().sprite = pirate;
				firstPlace.text = player4Score+" Points";
			} else if (player4Score == second) {
				secondPlaceSprite.GetComponent<Image>().sprite = pirate;
				secondPlace.text = player4Score+" Points";
			} else if (player4Score == third) {
				thirdPlaceSprite.GetComponent<Image>().sprite = pirate;
				thirdPlace.text = player4Score+" Points";
			} else {
				fourthPlaceSprite.GetComponent<Image>().sprite = pirate;
				fourthPlace.text = player4Score+" Points";
			}
		}
		p1Score.GetComponent<TextMesh>().text = ""+ScoreSystem.Instance.player1Score+" Points";
		p2Score.GetComponent<TextMesh>().text = ""+ScoreSystem.Instance.player2Score+" Points";
		p3Score.GetComponent<TextMesh>().text = ""+ScoreSystem.Instance.player3Score+" Points";
		p4Score.GetComponent<TextMesh>().text = ""+ScoreSystem.Instance.player4Score+" Points";


		if (timer.GetComponent<SceneTransition> ().timer <= 3) {
			exit.transform.Translate(Vector3.right * (speed*Time.deltaTime));
		}
	}
		
}
