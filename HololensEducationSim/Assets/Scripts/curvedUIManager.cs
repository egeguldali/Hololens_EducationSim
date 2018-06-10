using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class curvedUIManager : MonoBehaviour {


    public int caseID;

    public GameObject gameobj;
   

    public Sprite[] Case_Tetkik_Images_ToUpload;       //Konulmak istenen tetkik case Fotoğrafları
    public string[] Case_Tetkik_Texts_ToUpload;       //Konulmak istenen tetkik case başlıkları

    public Sprite[] Case_Tibbi_Girisim_Images_ToUpload;    //Konulmak istenen Tıbbi Girişim case Fotoğrafları   
    public string[] Case_Tibbi_Girisim_Texts_ToUpload;    //Konulmak istenen Tıbbi Girişim case başlıkları


    public Sprite[] Case_First_MenuRight_Images_ToUpload;    //Konulmak istenen Tıbbi Girişim case Fotoğrafları   

    public Sprite[] Case_Second_MenuRight_Images_ToUpload;    //Konulmak istenen Tıbbi Girişim case Fotoğrafları   
    



    int i;

    void Start()
    {
        changeVariablesCase();
        
    }

    void openThirdColumn()
    {

        keepPath getPath = gameobj.GetComponent<keepPath>();

        if (Case_Tetkik_Texts_ToUpload.Length == 5)
        {
            getPath.ThirdMainColumnTetkik.SetActive(true);
            getPath.ThirdColumnUpperTetkik.SetActive(true);
            getPath.ThirdColumnLowerTetkik.SetActive(false);

        }
        else if (Case_Tetkik_Texts_ToUpload.Length == 6)
        {
            getPath.ThirdMainColumnTetkik.SetActive(true);
            getPath.ThirdColumnLowerTetkik.SetActive(true);
            getPath.ThirdColumnUpperTetkik.SetActive(true);

        }
        else
        {
            getPath.ThirdMainColumnTetkik.SetActive(false);
        }
        /********************************************************/
        if (Case_Tibbi_Girisim_Images_ToUpload.Length == 5)
        {
            getPath.ThirdMainColumnTibbi.SetActive(true);
            getPath.ThirdColumnUpperTibbi.SetActive(true);
            getPath.ThirdColumnLowerTibbi.SetActive(false);
        }
        else if (Case_Tibbi_Girisim_Images_ToUpload.Length == 6)
        {
            getPath.ThirdMainColumnTibbi.SetActive(true);
            getPath.ThirdColumnUpperTibbi.SetActive(true);
            getPath.ThirdColumnLowerTibbi.SetActive(true);
        }
        else
        {
            getPath.ThirdMainColumnTibbi.SetActive(false);
            getPath.ThirdColumnLowerTibbi.SetActive(false);
            getPath.ThirdColumnUpperTibbi.SetActive(false);

        }
    }



    public void changeVariablesCase()
    {
        openThirdColumn();

       keepPath getPath = gameobj.GetComponent<keepPath>();

        Image[] Tetkik_imagePaths = getPath.Tetkik_imagePaths;
        Text[] Tetkik_textPaths = getPath.Tetkik_textPaths;

        Image[] Tibbi_Girisim_imagePaths = getPath.Tibbi_Girisim_imagePaths;
        Text[] Tibbi_Girisim_textPaths = getPath.Tibbi_Girisim_textPaths;

        Image[] First_Menu_RightImages = getPath.First_Menu_RightImages;
        Text[] First_Menu_RightTexts = getPath.First_Menu_RightTexts;

        Image[] Second_Menu_RightImages = getPath.Second_Menu_RightImages;
        Text[] Second_Menu_RightTexts = getPath.Second_Menu_RightTexts;


        for (i = 0; i < Case_Tetkik_Images_ToUpload.Length; i++)    //Tetkik resilmlerinin değişimi
        {
            Tetkik_imagePaths[i].sprite = Case_Tetkik_Images_ToUpload[i];
        }

        for (i = 0; i < Case_Tetkik_Texts_ToUpload.Length; i++)       //Tetkik başlıklarının değiştirilmesi
        {
            Tetkik_textPaths[i].text = Case_Tetkik_Texts_ToUpload[i];
        }

        for (i = 0; i < Case_Tibbi_Girisim_Images_ToUpload.Length; i++)       // Tıbbi Girişim resimlerinin değiştirilmesi
        {
            Tibbi_Girisim_imagePaths[i].sprite = Case_Tibbi_Girisim_Images_ToUpload[i];
        }

        for (i = 0; i < Case_Tibbi_Girisim_Texts_ToUpload.Length; i++)        // Tıbbi girişim Başlıklarının değiştirilmesi
        {
            Tibbi_Girisim_textPaths[i].text = Case_Tibbi_Girisim_Texts_ToUpload[i];
        }


        for (i = 0; i < Case_First_MenuRight_Images_ToUpload.Length; i++)        // 1
        {
            First_Menu_RightImages[i].sprite = Case_First_MenuRight_Images_ToUpload[i];
        }

        for (i = 0; i < Case_Tetkik_Texts_ToUpload.Length; i++)        // 2
        {
            First_Menu_RightTexts[i].text = Case_Tetkik_Texts_ToUpload[i];
        }


        for (i = 0; i < Case_Second_MenuRight_Images_ToUpload.Length; i++)        // 3
        {
            Second_Menu_RightImages[i].sprite = Case_Second_MenuRight_Images_ToUpload[i];
        }


        for (i = 0; i < Case_Tibbi_Girisim_Texts_ToUpload.Length; i++)        // 4
        {
            Second_Menu_RightTexts[i].text = Case_Tibbi_Girisim_Texts_ToUpload[i];
        }




    }

    


}
