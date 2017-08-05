using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsolePrinter : MonoBehaviour {

	public Vector2 location;
	public Vector2 homeLocation; // Distance in meters.


	// Use this for initialization
	void Start () {


		print ("Hello World, Welcome to Go Home");
		print ("I will finish the Go home chapter before \n 3 oclock today");


	}
	// Update is called once per frame
	void Update () {
		CheckForMovement(KeyCode.LeftArrow, new Vector2(-1,0));
		CheckForMovement(KeyCode.RightArrow, new Vector2(1,0));
		CheckForMovement(KeyCode.UpArrow, new Vector2(0,1));
		CheckForMovement(KeyCode.DownArrow, new Vector2(0,-1));
	}

	void CheckForMovement(KeyCode kc, Vector2 movementVector){
	
		if (Input.GetKeyDown (kc)) {
		
			location = location + movementVector;
			Vector2 pathToHome = homeLocation - location;
			print ("Distance to home : " + pathToHome.magnitude);

			if (location == homeLocation) {
				print ("I am at home ");
			}
		}


	}
}
