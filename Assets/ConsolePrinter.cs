using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsolePrinter : MonoBehaviour {

	// Use this for initialization
	void Start () {

		int someNumber;
		someNumber = 1;
		float Location;
		Location = 23.7676f;

		print ("Hello World, Learning Unity is real fun");
		print ("I will finish the Go home chapter before \n 3 oclock today");
		print ("The number is "+ someNumber);

		print ("The real number is "+ Location);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
