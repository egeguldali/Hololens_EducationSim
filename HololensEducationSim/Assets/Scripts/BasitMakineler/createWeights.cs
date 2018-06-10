using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createWeights : MonoBehaviour
{

    public GameObject weightToPlace;
    public GameObject long_Kaldirac;
    public GameObject small_Kaldirac;
    public GameObject parent_Weight;

    private GameObject clonePos1;
    private GameObject clonePos2;
    private GameObject cloneNeg;

    GameObject[] clones;


    public int i;



    public void createCentersOnPlane()
    {
        i = 0;


        clonePos1 = GameObject.Instantiate(weightToPlace, weightToPlace.transform.position, weightToPlace.transform.rotation, parent_Weight.transform);
        clonePos1.transform.position += new Vector3(0.2f, 0, 0);


        cloneNeg = GameObject.Instantiate(weightToPlace, weightToPlace.transform.position, weightToPlace.transform.rotation, parent_Weight.transform);
        cloneNeg.transform.position += new Vector3(-0.2f, 0, 0);


        clonePos2 = GameObject.Instantiate(weightToPlace, weightToPlace.transform.position, weightToPlace.transform.rotation, parent_Weight.transform);
        clonePos2.transform.position += new Vector3(0.4f, 0, 0);


        cloneNeg = GameObject.Instantiate(weightToPlace, weightToPlace.transform.position, weightToPlace.transform.rotation, parent_Weight.transform);
        cloneNeg.transform.position += new Vector3(-0.4f, 0, 0);


        clonePos2 = GameObject.Instantiate(weightToPlace, weightToPlace.transform.position, weightToPlace.transform.rotation, parent_Weight.transform);
        clonePos2.transform.position += new Vector3(0.6f, 0, 0);


        clonePos2 = GameObject.Instantiate(weightToPlace, weightToPlace.transform.position, weightToPlace.transform.rotation, parent_Weight.transform);
        clonePos2.transform.position += new Vector3(-0.6f, 0, 0);

        clonePos2 = GameObject.Instantiate(weightToPlace, weightToPlace.transform.position, weightToPlace.transform.rotation, parent_Weight.transform);
        clonePos2.transform.position += new Vector3(0.8f, 0, 0);

        clonePos2 = GameObject.Instantiate(weightToPlace, weightToPlace.transform.position, weightToPlace.transform.rotation, parent_Weight.transform);
        clonePos2.transform.position += new Vector3(-0.8f, 0, 0);


        clonePos2 = GameObject.Instantiate(weightToPlace, weightToPlace.transform.position, weightToPlace.transform.rotation, parent_Weight.transform);
        clonePos2.transform.position += new Vector3(1f, 0, 0);

        clonePos2 = GameObject.Instantiate(weightToPlace, weightToPlace.transform.position, weightToPlace.transform.rotation, parent_Weight.transform);
        clonePos2.transform.position += new Vector3(-1f, 0, 0);


        if (long_Kaldirac.activeSelf)
        {
            clonePos1 = GameObject.Instantiate(weightToPlace, weightToPlace.transform.position, weightToPlace.transform.rotation, parent_Weight.transform);
            clonePos1.transform.position += new Vector3(1.2f, 0, 0);


            cloneNeg = GameObject.Instantiate(weightToPlace, weightToPlace.transform.position, weightToPlace.transform.rotation, parent_Weight.transform);
            cloneNeg.transform.position += new Vector3(-1.2f, 0, 0);


            clonePos2 = GameObject.Instantiate(weightToPlace, weightToPlace.transform.position, weightToPlace.transform.rotation, parent_Weight.transform);
            clonePos2.transform.position += new Vector3(1.4f, 0, 0);


            cloneNeg = GameObject.Instantiate(weightToPlace, weightToPlace.transform.position, weightToPlace.transform.rotation, parent_Weight.transform);
            cloneNeg.transform.position += new Vector3(-1.4f, 0, 0);


            clonePos2 = GameObject.Instantiate(weightToPlace, weightToPlace.transform.position, weightToPlace.transform.rotation, parent_Weight.transform);
            clonePos2.transform.position += new Vector3(1.6f, 0, 0);


            clonePos2 = GameObject.Instantiate(weightToPlace, weightToPlace.transform.position, weightToPlace.transform.rotation, parent_Weight.transform);
            clonePos2.transform.position += new Vector3(-1.6f, 0, 0);

            clonePos2 = GameObject.Instantiate(weightToPlace, weightToPlace.transform.position, weightToPlace.transform.rotation, parent_Weight.transform);
            clonePos2.transform.position += new Vector3(1.8f, 0, 0);

            clonePos2 = GameObject.Instantiate(weightToPlace, weightToPlace.transform.position, weightToPlace.transform.rotation, parent_Weight.transform);
            clonePos2.transform.position += new Vector3(-1.8f, 0, 0);


            clonePos2 = GameObject.Instantiate(weightToPlace, weightToPlace.transform.position, weightToPlace.transform.rotation, parent_Weight.transform);
            clonePos2.transform.position += new Vector3(2f, 0, 0);

            clonePos2 = GameObject.Instantiate(weightToPlace, weightToPlace.transform.position, weightToPlace.transform.rotation, parent_Weight.transform);
            clonePos2.transform.position += new Vector3(-2f, 0, 0);


        }

    }


    public void createWeightsOnPlane()
    {
        i = 0;


        clonePos1 = GameObject.Instantiate(weightToPlace, weightToPlace.transform.position, weightToPlace.transform.rotation, parent_Weight.transform);
        clonePos1.transform.position += new Vector3(0.2f, 0, 0);


        cloneNeg = GameObject.Instantiate(weightToPlace, weightToPlace.transform.position, weightToPlace.transform.rotation, parent_Weight.transform);
        cloneNeg.transform.position += new Vector3(-0.2f, 0, 0);


        clonePos2 = GameObject.Instantiate(weightToPlace, weightToPlace.transform.position, weightToPlace.transform.rotation, parent_Weight.transform);
        clonePos2.transform.position += new Vector3(0.4f, 0, 0);


        cloneNeg = GameObject.Instantiate(weightToPlace, weightToPlace.transform.position, weightToPlace.transform.rotation, parent_Weight.transform);
        cloneNeg.transform.position += new Vector3(-0.4f, 0, 0);


        clonePos2 = GameObject.Instantiate(weightToPlace, weightToPlace.transform.position, weightToPlace.transform.rotation, parent_Weight.transform);
        clonePos2.transform.position += new Vector3(0.6f, 0, 0);


        clonePos2 = GameObject.Instantiate(weightToPlace, weightToPlace.transform.position, weightToPlace.transform.rotation, parent_Weight.transform);
        clonePos2.transform.position += new Vector3(-0.6f, 0, 0);

        clonePos2 = GameObject.Instantiate(weightToPlace, weightToPlace.transform.position, weightToPlace.transform.rotation, parent_Weight.transform);
        clonePos2.transform.position += new Vector3(0.8f, 0, 0);

        clonePos2 = GameObject.Instantiate(weightToPlace, weightToPlace.transform.position, weightToPlace.transform.rotation, parent_Weight.transform);
        clonePos2.transform.position += new Vector3(-0.8f, 0, 0);


        clonePos2 = GameObject.Instantiate(weightToPlace, weightToPlace.transform.position, weightToPlace.transform.rotation, parent_Weight.transform);
        clonePos2.transform.position += new Vector3(1f, 0, 0);

        clonePos2 = GameObject.Instantiate(weightToPlace, weightToPlace.transform.position, weightToPlace.transform.rotation, parent_Weight.transform);
        clonePos2.transform.position += new Vector3(-1f, 0, 0);


        if (long_Kaldirac.activeSelf)
        {
            clonePos1 = GameObject.Instantiate(weightToPlace, weightToPlace.transform.position, weightToPlace.transform.rotation, parent_Weight.transform);
            clonePos1.transform.position += new Vector3(1.2f, 0, 0);


            cloneNeg = GameObject.Instantiate(weightToPlace, weightToPlace.transform.position, weightToPlace.transform.rotation, parent_Weight.transform);
            cloneNeg.transform.position += new Vector3(-1.2f, 0, 0);


            clonePos2 = GameObject.Instantiate(weightToPlace, weightToPlace.transform.position, weightToPlace.transform.rotation, parent_Weight.transform);
            clonePos2.transform.position += new Vector3(1.4f, 0, 0);


            cloneNeg = GameObject.Instantiate(weightToPlace, weightToPlace.transform.position, weightToPlace.transform.rotation, parent_Weight.transform);
            cloneNeg.transform.position += new Vector3(-1.4f, 0, 0);


            clonePos2 = GameObject.Instantiate(weightToPlace, weightToPlace.transform.position, weightToPlace.transform.rotation, parent_Weight.transform);
            clonePos2.transform.position += new Vector3(1.6f, 0, 0);


            clonePos2 = GameObject.Instantiate(weightToPlace, weightToPlace.transform.position, weightToPlace.transform.rotation, parent_Weight.transform);
            clonePos2.transform.position += new Vector3(-1.6f, 0, 0);

            clonePos2 = GameObject.Instantiate(weightToPlace, weightToPlace.transform.position, weightToPlace.transform.rotation, parent_Weight.transform);
            clonePos2.transform.position += new Vector3(1.8f, 0, 0);

            clonePos2 = GameObject.Instantiate(weightToPlace, weightToPlace.transform.position, weightToPlace.transform.rotation, parent_Weight.transform);
            clonePos2.transform.position += new Vector3(-1.8f, 0, 0);


            clonePos2 = GameObject.Instantiate(weightToPlace, weightToPlace.transform.position, weightToPlace.transform.rotation, parent_Weight.transform);
            clonePos2.transform.position += new Vector3(2f, 0, 0);

            clonePos2 = GameObject.Instantiate(weightToPlace, weightToPlace.transform.position, weightToPlace.transform.rotation, parent_Weight.transform);
            clonePos2.transform.position += new Vector3(-2f, 0, 0);


        }

    }


    public void destroyClones()
    {
        var weightclones = GameObject.FindGameObjectsWithTag("weight");

        foreach (var item in weightclones)
        {

            item.SetActive(false);

        }
    }
    public void createClonesAgain()
    {
        var weightclones = GameObject.FindGameObjectsWithTag("weight");

        foreach (var item in weightclones)
        {

            item.SetActive(true);

        }
    }



}
