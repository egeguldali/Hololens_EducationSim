using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour {

    public GameObject center;

    public int orbit;
    public int speed;

    // Update is called once per frame
    void Update () {


        transform.RotateAround(center.transform.position,center.transform.right, 25*Time.deltaTime*orbit* speed);

	}

    
}
