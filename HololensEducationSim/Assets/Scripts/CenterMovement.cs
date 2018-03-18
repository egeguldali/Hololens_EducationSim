using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterMovement : MonoBehaviour {

    
    public GameObject longObj;
    public GameObject shortObj;



    public void goRight()
    {
        if (longObj.activeSelf == true)
        {
            if (transform.localPosition.z <= 9.8f )
            {
                print(transform.localPosition.z);
                transform.position += new Vector3(0.2f,0,0);
            }
        }
        if (shortObj.activeSelf == true)
        {
            if (transform.localPosition.z <= 4.8f )
               transform.position += new Vector3(0.2f, 0, 0);
        }
    }

    public void goLeft()
    {
        if (longObj.activeSelf == true)
        {
            if (transform.localPosition.z > -9.8f) 
                transform.position += new Vector3(-0.2f, 0, 0);
        }
        if (shortObj.activeSelf == true)
        {
            if (transform.localPosition.z >= -4.8f )
                transform.position += new Vector3(-0.2f, 0, 0);
        }
    }

}
