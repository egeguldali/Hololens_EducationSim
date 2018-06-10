using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class resetSystem : MonoBehaviour {

    public GameObject x;
    public GameObject y;

    public void resetTransforms()
    {

        GameObject.Destroy(x);
        GameObject.Destroy(y);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }


}
