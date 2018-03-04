using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateElectron : MonoBehaviour {

    public GameObject[] electron;
    public GameObject[] orbits;
    
    public int[] arrayElectron;
    //public int number;
    public GameObject center;
    public GameObject element;


    private void Start()
    {
        //GameObject clone;
        //clone = GameObject.Instantiate(electron);
        //clone.transform.parent = center.transform;
        //clone.transform.RotateAround(center.transform.position, center.transform.right, 200);
        for(int x = 0; x <= electron.Length-1; x++)
        {
            electron[x].SetActive(false);
        }

        for(int y = 0; y <= orbits.Length-1; y++)
        {
            orbits[y].SetActive(false);
        }
        
        arrayElectron = element.GetComponent<ElectronOrder>().orders;

        for (int m = 0; m <= arrayElectron.Length - 1; m++)
        {
            orbits[m].SetActive(true);
        }

        createModel();



    }

    public void createModel()
    {

        for (int k = 0; k <= arrayElectron.Length; k++)
        {

            int number = arrayElectron[k];

            for (int i = 0; i <= number - 1; i++)
            {
                GameObject clone;
                clone = GameObject.Instantiate(electron[k], electron[k].transform.position, electron[k].transform.rotation, center.transform);
                clone.transform.RotateAround(center.transform.position, center.transform.right, (360 / number) * i);
                clone.SetActive(true);
            }
        }


    }

}
