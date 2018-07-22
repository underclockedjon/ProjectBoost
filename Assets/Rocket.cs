using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {

    Rigidbody rigidbody;
    AudioSource audioSource;

	// Use this for initialization
	void Start () {
        //Find the Ridged Body 
        rigidbody = GetComponent<Rigidbody>();
	    audioSource = GetComponent<AudioSource>();
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
            //Make some noise, but restart playing if its already going
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
            
        }
        else
        {
            if (audioSource.isPlaying)
            {
                audioSource.Stop();
            }
        }

        if(Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(- Vector3.forward);
        }
    }
}
