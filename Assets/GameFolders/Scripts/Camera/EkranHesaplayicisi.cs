﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EkranHesaplayicisi : MonoBehaviour
{
    public static EkranHesaplayicisi instance;
    float yukseklik;
    float genislik;
    public float Yukseklik
    {
        get
        {
            return yukseklik;
        }
    }
    public float Genislik
    {
        get
        {
            return genislik;
        }
    }
    void Awake()
    {
        instance = this;
        yukseklik = Camera.main.orthographicSize;
        genislik = yukseklik * Camera.main.aspect;
    }
   

    // Update is called once per frame
    void Update()
    {
        
    }
}
