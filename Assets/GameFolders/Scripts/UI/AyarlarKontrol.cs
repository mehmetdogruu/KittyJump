using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AyarlarKontrol : MonoBehaviour
{
    public Button kolayButon, ortaButon, zorButon;
    void Start()
    {
        if (Settings.KolayDegerOku()==1)
        {
            kolayButon.interactable = false;
            ortaButon.interactable = true;
            zorButon.interactable = true;
        }
        if (Settings.OrtaDegerOku() == 1)
        {
            kolayButon.interactable = true;
            ortaButon.interactable =false;
            zorButon.interactable = true;
        }
        if (Settings.ZorDegerOku() == 1)
        {
            kolayButon.interactable = true;
            ortaButon.interactable = true;
            zorButon.interactable = false;
        }
    }

    void Update()
    {
        
    }
    public void SecenekSecildi(string seviye)
    {
        switch (seviye)
        {
            case "kolay":
                Settings.KolayDegerAta(1);
                Settings.OrtaDegerAta(0);
                Settings.ZorDegerAta(0);
                kolayButon.interactable = false;
                ortaButon.interactable = true;
                zorButon.interactable = true;
                break;
            case "orta":
                Settings.KolayDegerAta(0);
                Settings.OrtaDegerAta(1);
                Settings.ZorDegerAta(0);
                kolayButon.interactable = true;
                ortaButon.interactable = false;
                zorButon.interactable = true;
                break;
            case "zor":
                Settings.KolayDegerAta(0);
                Settings.OrtaDegerAta(0);
                Settings.ZorDegerAta(1);
                kolayButon.interactable = true;
                ortaButon.interactable = true;
                zorButon.interactable = false;
                break;
            default:
                break;
        }
    }
    public void AnaMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
