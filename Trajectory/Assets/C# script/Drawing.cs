using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drawing : MonoBehaviour {


	public float speed = 5.0f; //initial speed of the trajectory
	public float angle = 30.0f; //initial angle of the trajectory
	public GameObject other; // the object that is going to travel
	public float timeResolution = 0.2f; // time Resolution 

	// Use this for initialization
	// Purpose: 1. Set the inital angle of the obeject 
	//         
	void Start () {
		//1.Set the inital angle of the obeject
		other.transform.rotation = Quaternion.Euler(angle,0.0f,0.0f);
				
	}
	
	void FixedUpdate()
	{
	
	
	
	}

	// Update is called once per frame
	void Update () {
		
	}
}
