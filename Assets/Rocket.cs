using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {

    Rigidbody rigidbody;

	// Use this for initialization
	void Start () {
        //Find the Ridged Body 
        rigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        ProcessInput();
	}

    private void ProcessInput()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            rigidbody.AddRelativeForce(Vector3.up);
        }

        if(Input.GetKey(KeyCode.A))
        {
            print("pressing A Only");
        }

        else if (Input.GetKey(KeyCode.D))
        {
            print("pressing D Only");
        }
    }
}
