using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraHareket : MonoBehaviour
{
    float hiz;
    float hizlanma;
    float maksimumHiz;
    bool hareket;



    void Start()
    {
        hareket = true;
        if (Settings.KolayDegerOku()==1)
        {
            hiz = 0.3f;
            hizlanma = 0.03f;
            maksimumHiz = 1.5f;
        }
        if (Settings.OrtaDegerOku() == 1)
        {
            hiz = 0.5f;
            hizlanma = 0.05f;
            maksimumHiz = 2.0f;
        }
        if (Settings.ZorDegerOku() == 1)
        {
            hiz = 0.7f;
            hizlanma = 0.07f;
            maksimumHiz = 2.5f;
        }
        
        
    }

    void Update()
    {
        if (hareket)
        {
            KamerayıHareketEttir();

        }
    }
    void KamerayıHareketEttir()
    {
        transform.position += transform.up * hiz * Time.deltaTime;
        hiz += hizlanma * Time.deltaTime;
        if (hiz>=maksimumHiz)
        {
            hiz = maksimumHiz;
        }
    }
    public void OyunBitti()
    {
        hareket = false;
    }
}
