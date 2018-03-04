using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateDna : MonoBehaviour {

    public GameObject AT_Nucleotid;
    public GameObject GC_Nucleotid;
    public GameObject DNA_parent;
    public Transform DNA_parnt;

    public Text bagSayisi_T;
    public Text A_T;
    public Text G_T;
    //private GameObject[] nucleotidArray;

    public int order;
    public int bagSayisi;
    public int A_sayisi;
    public int G_sayisi;



    // Use this for initialization
    void Start () {

        order = 0;
        bagSayisi = 0;
        A_sayisi = 0;
        G_sayisi = 0;

}

    private void Update()
    {
        bagSayisi_T.text = "Toplam bag sayısı = " + bagSayisi;
        A_T.text = "Toplam Adenin sayısı = Toplam Timin sayısı = " + A_sayisi;
        G_T.text = "Toplam Guanin sayısı = Toplam Sitozin sayısı = " + G_sayisi;
  
    }

    public void place_GC() {

        GameObject clone;
        clone = GameObject.Instantiate(GC_Nucleotid, GC_Nucleotid.transform.position, GC_Nucleotid.transform.rotation, DNA_parent.transform);
        clone.transform.position = new Vector3(0, order, 0);
        clone.transform.Rotate(new Vector3(0, order * 30, 0));
        order = order + 1;

        bagSayisi += 3;
        G_sayisi += 1;

        //clone = nucleotidArray[order];

    }
    public void place_AT()
    {
        GameObject clone;
        clone = GameObject.Instantiate(AT_Nucleotid, AT_Nucleotid.transform.position, AT_Nucleotid.transform.rotation, DNA_parent.transform);
        clone.transform.position =new Vector3(0, order, 0);
        clone.transform.Rotate(new Vector3(0, order * 30, 0));
        order = order + 1;

        bagSayisi += 2;
        A_sayisi += 1;
        
        //clone = nucleotidArray[order];
    }

    public void destroyDNA()
    {
        foreach (Transform child in DNA_parnt)
        {
            GameObject.Destroy(child.gameObject);
        }
        order = 0;
        A_sayisi = 0;
        G_sayisi = 0;
        bagSayisi = 0;
    }

}
