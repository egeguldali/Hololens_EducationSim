using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseAllTaps : MonoBehaviour {


    public GameObject[] allTabs;

    int i;

	public void closeOperation()
    {
        for(i =0; i < allTabs.Length; i++)
        {

            allTabs[i].SetActive(false);

        }
    }


}
