using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraHareket : MonoBehaviour
{
    float hiz;
    float hizlanma;
    float maksimumHiz;
    bool hareket=true;



    void Start()
    {
        hiz = 0.5f;
        hizlanma = 0.05f;
        maksimumHiz = 2.0f;
        
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
}
