using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursorSizeModifier : MonoBehaviour {
    public GameObject myCursorOnHolograms;
    float x, y, z;

	// Use this for initialization
	void Start () {
        x = myCursorOnHolograms.transform.localScale.x;
        y = myCursorOnHolograms.transform.localScale.y;
        z = myCursorOnHolograms.transform.localScale.z;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void onCanvas() {
        myCursorOnHolograms.transform.localScale = new Vector3(.6f, .6f, 2.2f);

    }
    public void offCanvas()
    {
        myCursorOnHolograms.transform.localScale = new Vector3(x,y,z);

    }
}
