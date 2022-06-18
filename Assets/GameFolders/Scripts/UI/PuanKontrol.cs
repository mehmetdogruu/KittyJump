using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PuanKontrol : MonoBehaviour
{
    public Text kolayPuan, kolayMama, ortaPuan, ortaMama, zorPuan, zorMama;
    void Start()
    {
        kolayPuan.text = "POINT: " + Settings.KolayPuanDegerOku();
        kolayMama.text = "x" + Settings.KolayMamaDegerOku();
        ortaPuan.text= "POINT: " + Settings.OrtaPuanDegerOku();
        ortaMama.text = "x" + Settings.OrtaMamaDegerOku();
        zorPuan.text = "POINT: " + Settings.ZorPuanDegerOku();
        zorMama.text = "x" + Settings.ZorMamaDegerOku();
    }

   
    public void AnaMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    }
