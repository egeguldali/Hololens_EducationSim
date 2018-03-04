using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScene : MonoBehaviour {

    public GameObject x;
    public GameObject y;


    public void openPeriodicTable()
    {
        GameObject.Destroy(x);
        GameObject.Destroy(y);
        SceneManager.LoadScene("PeriodicTable");
    }

    public void openDNA()
    {
        GameObject.Destroy(x);
        GameObject.Destroy(y);
        SceneManager.LoadScene("Dna_Structer");
    }

}
