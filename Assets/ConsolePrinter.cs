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
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			location = location + new Vector2 (-1.0f, 0);

			Vector2 pathToHome = homeLocation - location;
			print ("Distance to home : " + pathToHome.magnitude);

			if (location == homeLocation) {
				print ("I am at home ");
			}
		}
		if (Input.GetKeyDown (KeyCode.RightArrow)) {

			location = location + new Vector2 (1.0f, 0);
			Vector2 pathToHome = homeLocation - location;
			print ("Distance to home : " + pathToHome.magnitude);

			if (location == homeLocation) {
				print ("I am at home ");
			}
		}

		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			location = location + new Vector2 (0, 1);
			Vector2 pathToHome = homeLocation - location;
			print ("Distance to home : " + pathToHome.magnitude);

			if (location == homeLocation) {
				print ("I am at home ");
			}
		}
		if (Input.GetKeyDown (KeyCode.DownArrow)) {

			location = location + new Vector2 (0, -1);
			Vector2 pathToHome = homeLocation - location;
			print ("Distance to home : " + pathToHome.magnitude);

			if (location == homeLocation) {
				print ("I am at home ");
			}

		}
	}
}
