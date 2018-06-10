using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class assignWeight : MonoBehaviour {

    
    public Rigidbody rb;

	// Use this for initialization
	void Start () {

        rb = GetComponent<Rigidbody>();
        
	}
	

    public void weightFive()
    {
        float mass = 5.0f;

        rb.mass = mass;
    }
    public void weightTen()
    {
        float mass = 10.0f;

        rb.mass = mass;
    }


    public void weightTwenty()
    {
        float mass = 20.0f;

        rb.mass = mass;
    }


    public void weightTwentyFive()
    {
        float mass = 25.0f;

        rb.mass = mass;
    }

}
