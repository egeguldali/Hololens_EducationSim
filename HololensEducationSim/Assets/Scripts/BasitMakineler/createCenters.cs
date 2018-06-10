using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createCenters : MonoBehaviour {

    public GameObject centerToPlace;
    public GameObject long_Kaldirac;
    public GameObject small_Kaldirac;
    public GameObject parent_Kaldirac;

    private GameObject clonePos1;
    private GameObject clonePos2;
    private GameObject cloneNeg;

    GameObject[] clones;


    public int i;



    public void createCentersOnPlane()
    {
        i = 0;

       
        clonePos1 = GameObject.Instantiate(centerToPlace, centerToPlace.transform.position, centerToPlace.transform.rotation, parent_Kaldirac.transform);
        clonePos1.transform.position += new Vector3(0.2f,0,0);
       

        cloneNeg = GameObject.Instantiate(centerToPlace, centerToPlace.transform.position, centerToPlace.transform.rotation, parent_Kaldirac.transform);
        cloneNeg.transform.position += new Vector3(-0.2f, 0, 0);


        clonePos2 = GameObject.Instantiate(centerToPlace, centerToPlace.transform.position, centerToPlace.transform.rotation, parent_Kaldirac.transform);
        clonePos2.transform.position += new Vector3(0.4f, 0, 0);


        cloneNeg = GameObject.Instantiate(centerToPlace, centerToPlace.transform.position, centerToPlace.transform.rotation, parent_Kaldirac.transform);
        cloneNeg.transform.position += new Vector3(-0.4f,0,0);


        clonePos2 = GameObject.Instantiate(centerToPlace, centerToPlace.transform.position, centerToPlace.transform.rotation, parent_Kaldirac.transform);
        clonePos2.transform.position += new Vector3(0.6f, 0, 0);


        clonePos2 = GameObject.Instantiate(centerToPlace, centerToPlace.transform.position, centerToPlace.transform.rotation, parent_Kaldirac.transform);
        clonePos2.transform.position += new Vector3(-0.6f, 0, 0);

        clonePos2 = GameObject.Instantiate(centerToPlace, centerToPlace.transform.position, centerToPlace.transform.rotation, parent_Kaldirac.transform);
        clonePos2.transform.position += new Vector3(0.8f, 0, 0);

        clonePos2 = GameObject.Instantiate(centerToPlace, centerToPlace.transform.position, centerToPlace.transform.rotation, parent_Kaldirac.transform);
        clonePos2.transform.position += new Vector3(-0.8f, 0, 0);


        clonePos2 = GameObject.Instantiate(centerToPlace, centerToPlace.transform.position, centerToPlace.transform.rotation, parent_Kaldirac.transform);
        clonePos2.transform.position += new Vector3(1f, 0, 0);

        clonePos2 = GameObject.Instantiate(centerToPlace, centerToPlace.transform.position, centerToPlace.transform.rotation, parent_Kaldirac.transform);
        clonePos2.transform.position += new Vector3(-1f, 0, 0);


        if (long_Kaldirac.activeSelf)
        {
            clonePos1 = GameObject.Instantiate(centerToPlace, centerToPlace.transform.position, centerToPlace.transform.rotation, parent_Kaldirac.transform);
            clonePos1.transform.position += new Vector3(1.2f, 0, 0);


            cloneNeg = GameObject.Instantiate(centerToPlace, centerToPlace.transform.position, centerToPlace.transform.rotation, parent_Kaldirac.transform);
            cloneNeg.transform.position += new Vector3(-1.2f, 0, 0);


            clonePos2 = GameObject.Instantiate(centerToPlace, centerToPlace.transform.position, centerToPlace.transform.rotation, parent_Kaldirac.transform);
            clonePos2.transform.position += new Vector3(1.4f, 0, 0);


            cloneNeg = GameObject.Instantiate(centerToPlace, centerToPlace.transform.position, centerToPlace.transform.rotation, parent_Kaldirac.transform);
            cloneNeg.transform.position += new Vector3(-1.4f, 0, 0);


            clonePos2 = GameObject.Instantiate(centerToPlace, centerToPlace.transform.position, centerToPlace.transform.rotation, parent_Kaldirac.transform);
            clonePos2.transform.position += new Vector3(1.6f, 0, 0);


            clonePos2 = GameObject.Instantiate(centerToPlace, centerToPlace.transform.position, centerToPlace.transform.rotation, parent_Kaldirac.transform);
            clonePos2.transform.position += new Vector3(-1.6f, 0, 0);

            clonePos2 = GameObject.Instantiate(centerToPlace, centerToPlace.transform.position, centerToPlace.transform.rotation, parent_Kaldirac.transform);
            clonePos2.transform.position += new Vector3(1.8f, 0, 0);

            clonePos2 = GameObject.Instantiate(centerToPlace, centerToPlace.transform.position, centerToPlace.transform.rotation, parent_Kaldirac.transform);
            clonePos2.transform.position += new Vector3(-1.8f, 0, 0);


            clonePos2 = GameObject.Instantiate(centerToPlace, centerToPlace.transform.position, centerToPlace.transform.rotation, parent_Kaldirac.transform);
            clonePos2.transform.position += new Vector3(2f, 0, 0);

            clonePos2 = GameObject.Instantiate(centerToPlace, centerToPlace.transform.position, centerToPlace.transform.rotation, parent_Kaldirac.transform);
            clonePos2.transform.position += new Vector3(-2f, 0, 0);


        }



        createClonesAgain();

   
        //if (long_Kaldirac.gameObject.activeSelf == true)
        //{
        //    for(int i = 0; i <= 20; i++)
        //    {
        //        GameObject clonePos;
        //        GameObject cloneNeg;
        //        clonePos = GameObject.Instantiate(centerToPlace, centerToPlace.transform.position, centerToPlace.transform.rotation, parent_Kaldirac.transform);
        //        clonePos.transform.position = new Vector3(i+1, 0, 0);

        //        cloneNeg = GameObject.Instantiate(centerToPlace, centerToPlace.transform.position, centerToPlace.transform.rotation, parent_Kaldirac.transform);
        //        cloneNeg.transform.position = new Vector3(i -1, 0, 0);


        //    }
        //}


    }

    public void destroyClones()
    {
        var clones = GameObject.FindGameObjectsWithTag("centers");

        foreach (var item in clones){

            item.SetActive(false);

        }
    }
    public void createClonesAgain()
    {
        var clones = GameObject.FindGameObjectsWithTag("centers");

        foreach (var item in clones)
        {

            item.SetActive(true);

        }
    }

}
