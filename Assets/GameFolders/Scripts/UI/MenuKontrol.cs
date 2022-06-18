using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuKontrol : MonoBehaviour
{
    [SerializeField]
    Sprite[] muzikIkonlar;
    [SerializeField]
    Button muzikButon;
    
    void Start()
    {
        if (Settings.KayitVarmi() == false)
        {
            Settings.KolayDegerAta(1);
        }
        if (Settings.MuzikVarmi()==false)
        {
            Settings.MuzikAcikDegerAta(1);
        }

        MuzikAyarlariniDenetle();

    }


    public void OyunuBaslat()
    {
        SceneManager.LoadScene("Oyun");
    }
    public void HighestPoint()
    {
        SceneManager.LoadScene("Puan");
    }
    public void Ayarlar()
    {
        SceneManager.LoadScene("Ayarlar");
    }


   
    public void Muzik()
    {
        if (Settings.MuzikAcikDegerOku() == 1)
        {
            Settings.MuzikAcikDegerAta(0);
            MuzikKontrol.instance.MuzikCal(false);
            muzikButon.image.sprite = muzikIkonlar[0];

        }
        else
        {
            Settings.MuzikAcikDegerAta(1);
            MuzikKontrol.instance.MuzikCal(true);
            muzikButon.image.sprite = muzikIkonlar[1];

            
           
        }
       
    }
    void MuzikAyarlariniDenetle()
    {
        if (Settings.MuzikAcikDegerOku() == 1)
        {
            muzikButon.image.sprite = muzikIkonlar[1];
            MuzikKontrol.instance.MuzikCal(true);
        }
        else
        {
            muzikButon.image.sprite = muzikIkonlar[0];
            MuzikKontrol.instance.MuzikCal(false);
        }
    }

}
