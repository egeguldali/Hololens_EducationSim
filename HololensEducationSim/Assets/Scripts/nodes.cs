using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nodes : MonoBehaviour {
    //node
    // create path on euntime with SWS


    public Vector3 Pozisyon { get; set; }
    public Quaternion Rotasyon { get; set; }
  
    public enum Animasyon
    {
        idle,
        walk,
        sit,
        sitinbed,
        tarti,
    };
    // node finish

    // Use this for initialization
    void Start () {
		


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
