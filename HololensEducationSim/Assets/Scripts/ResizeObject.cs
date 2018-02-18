using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResizeObject : MonoBehaviour {

    //public GameObject gameobject;
    public float scaleConstant;

    public void makeItSmaller()
    {

        transform.localScale = new Vector3(transform.localScale.x * 0.9f, transform.localScale.y * 0.9f, transform.localScale.z * 0.9f);

    }
    public void makeItBigger()
    {

        transform.localScale = new Vector3(transform.localScale.x / 0.9f, transform.localScale.y / 0.9f, transform.localScale.z / 0.9f);

    }

}
