using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour {


    private bool _rotate;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    public void Update()
    {
        if (_rotate)
        {
            transform.Rotate(new Vector3(0, 1 , 0));
        }
    }

    public void OnPress()
    {
        _rotate = true;
    }

    public void OnRelease()
    {
        _rotate = false;
        transform.Rotate(new Vector3(0, 0, 0));

       
    }
}
