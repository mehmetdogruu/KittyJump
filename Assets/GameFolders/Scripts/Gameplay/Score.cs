using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    int puan;
    int enYuksekPuan;
    int mama;
    int enYuksekMama;
    bool puanTopla;
    [SerializeField]
    Text puanText;
    [SerializeField]
    Text mamaText;
    [SerializeField]
    Text oyunBittiPuanText;
    [SerializeField]
    Text oyunBittiMamaText;
    void Start()
    {
       mamaText.text = "x"+ mama;
       puanTopla = true;

    }

    void Update()
    {
        if (puanTopla)
        {
            puan = (int)Camera.main.transform.position.y;
            puanText.text = "Score: " + puan;
        }
        
    }
    public void MamaKazan()
    {
        FindObjectOfType<SesKontrol>().MamaSes();
        mama++;
        mamaText.text = "x" + mama;

    }
    public void OyunBitti()
    {
        if (Settings.KolayDegerOku()==1)
        {
            enYuksekPuan = Settings.KolayPuanDegerOku();
            enYuksekMama = Settings.KolayMamaDegerOku();
            if (puan>enYuksekPuan)
            {
                Settings.KolayPuanDegerAta(puan);
            }
            if (mama>enYuksekMama)
            {
                Settings.KolayMamaDegerAta(mama);
            }
        }
        if (Settings.OrtaDegerOku() == 1)
        {
            enYuksekPuan = Settings.OrtaPuanDegerOku();
            enYuksekMama = Settings.OrtaMamaDegerOku();
            if (puan > enYuksekPuan)
            {
                Settings.OrtaPuanDegerAta(puan);
            }
            if (mama > enYuksekMama)
            {
                Settings.OrtaMamaDegerAta(mama);
            }
        }
        if (Settings.ZorDegerOku() == 1)
        {
            enYuksekPuan = Settings.ZorPuanDegerOku();
            enYuksekMama = Settings.ZorMamaDegerOku();
            if (puan > enYuksekPuan)
            {
                Settings.ZorPuanDegerAta(puan);
            }
            if (mama > enYuksekMama)
            {
                Settings.ZorMamaDegerAta(mama);
            }
        }
        puanTopla = false;
        oyunBittiPuanText.text = "Score :" + puan;
        oyunBittiMamaText.text = " x " + mama;
    }

}
