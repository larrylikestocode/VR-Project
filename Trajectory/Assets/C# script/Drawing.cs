using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drawing : MonoBehaviour {


	public float speed = 5.0f; //initial speed of the trajectory
	public float angle = 30.0f; //initial angle of the trajectory
	public GameObject other; // the object that is the starting point
	public GameObject dott; //dots that gonna draw
	public float timeResolution = 0.2f; // time Resolution 
	Vector3 start; //start position



	// Use this for initialization
	// Purpose: 1. Set the inital angle of the obeject 
	//         	2. 
	void Start () {
		//1.Set the inital angle of the obeject
		other.transform.rotation = Quaternion.Euler(0.0f,0.0f,angle);
		start = other.transform.position;		
	}
	
	void Update()
	{
		for (int index = 0; index < 100; index++) 
		{
			
			timeResolution += timeResolution;
			float dx = speed * timeResolution * Mathf.Cos (angle * Mathf.Deg2Rad);
			float dy = speed * timeResolution * Mathf.Sin (angle * Mathf.Deg2Rad) - (Physics.gravity.magnitude * timeResolution * timeResolution / 2.0f);
			Vector3 currentPosition = new Vector3 (start.x + dx, start.y + dy, 0); //restrict z value to 0
			Debug.Log (currentPosition);
			Instantiate (dott, currentPosition, transform.rotation);
		}
	}

	// Update is called once per frame

}
