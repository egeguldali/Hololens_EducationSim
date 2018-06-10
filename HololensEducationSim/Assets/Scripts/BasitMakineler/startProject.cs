using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startProject : MonoBehaviour {


    public GameObject kaldirac;
    

	public void openGravity()
    {
        Rigidbody rb = kaldirac.GetComponent<Rigidbody>();
        rb.useGravity = true;
        rb.isKinematic = false;
    }
}
