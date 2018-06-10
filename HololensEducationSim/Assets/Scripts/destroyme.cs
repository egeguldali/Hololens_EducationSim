using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyme : MonoBehaviour {

    public GameObject me; 
	// Use this for initialization
	void Start () {
        Invoke("destroyInvoked", 1f);
	}

    // Update is called once per frame
    public void destroyInvoked() { Destroy(me); }
}
