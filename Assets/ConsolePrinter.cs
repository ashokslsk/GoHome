using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsolePrinter : MonoBehaviour {

	// Use this for initialization
	void Start () {

		float Location = 5.0f; // Distance in meters.
		float homeLocation = 2.1f; // Distance in meters.
		float distnace = homeLocation - Location;

		print ("Hello World, Welcome to Go Home");
		print ("I will finish the Go home chapter before \n 3 oclock today");

		print ("Distance : " + distnace);

		if (Location > homeLocation) {
			
			print ("Go Back to get home");
		} 

		if(Location < homeLocation){
			print ("Go forward to get home");
		}

		if (Location == homeLocation) {
			print ("I am at home ");
		}
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			print ("Left key pressed");
		}
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			print ("Right key pressed");
		}
	}
}
