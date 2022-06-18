﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformPool : MonoBehaviour
{
    [SerializeField]
    GameObject platformPrefab;

    [SerializeField]
    GameObject playerPrefab;
    //[SerializeField]
    //GameObject ilkPlatformPrefab;
    [SerializeField]
    GameObject olumculPlatformPrefab;

    List<GameObject> platforms = new List<GameObject>();

    Vector2 platformPozisyon;
    Vector2 playerPozisyon;

    [SerializeField]
    float platformArasiMesafe;

    void Start()
    {
        PlatformUret();
    }

    void Update()
    {
        if (platforms[platforms.Count - 1].transform.position.y < Camera.main.transform.position.y + EkranHesaplayicisi.instance.Yukseklik)
        {
            PlatformYerlestir();
        }
    }
    void PlatformUret()
    {
        platformPozisyon = new Vector2(0, 0);
        playerPozisyon = new Vector2(0, 0.5f);
        GameObject player = Instantiate(playerPrefab, playerPozisyon, Quaternion.identity);
        GameObject ilkPlatform = Instantiate(platformPrefab, platformPozisyon, Quaternion.identity);
        player.transform.parent = ilkPlatform.transform;
        platforms.Add(ilkPlatform);
        SonrakiPlatformPozisyon();
        ilkPlatform.GetComponent<Platform>().Hareket = true;
        
        for (int i = 0; i < 8; i++)
        {
            //int randomForPlatform = Random.Range(0, platforms.Count);
            GameObject platform = Instantiate(platformPrefab, platformPozisyon, Quaternion.identity);
            platforms.Add(platform);
            platform.GetComponent<Platform>().Hareket = true;
            if (i%2==0)
            {
                platform.GetComponent<Mama>().MamaAc();
            }
            SonrakiPlatformPozisyon();
        }
        GameObject olumculPlatform = Instantiate(olumculPlatformPrefab, platformPozisyon, Quaternion.identity);
        olumculPlatform.GetComponent<DeathlyPlatform>().Hareket = true;
        platforms.Add(olumculPlatform);
        SonrakiPlatformPozisyon();
    }
    void PlatformYerlestir()
    {
        for (int i = 0; i < 5; i++)
        {
            GameObject temp;
            temp = platforms[i + 5];
            platforms[i + 5] = platforms[i];
            platforms[i] = temp;
            platforms[i + 5].transform.position = platformPozisyon;
            if (platforms[i + 5].gameObject.tag=="Platform")
            {
                platforms[i + 5].GetComponent<Mama>().MamaKapat();
                float rastgeleMama = Random.Range(0.0f, 1.0f);
                if (rastgeleMama>0.5f)
                {
                    platforms[i + 5].GetComponent<Mama>().MamaAc();

                }
            }
            SonrakiPlatformPozisyon();
        }
    }
    void SonrakiPlatformPozisyon()
    {
        platformPozisyon.y += platformArasiMesafe;
        SiraliPozisyon();
    }
    void KarmaPozisyon()
    {
        platformPozisyon.y += platformArasiMesafe;
        float random = Random.Range(0.0f, 1.0f);
        if (random < 0.5f)
        {
            platformPozisyon.x = EkranHesaplayicisi.instance.Genislik / 2;
        }
        else
        {
            platformPozisyon.x = -EkranHesaplayicisi.instance.Genislik / 2;
        }
    }
    bool yon = true;
    void SiraliPozisyon()
    {
        if (yon)
        {
            platformPozisyon.x = EkranHesaplayicisi.instance.Genislik / 2;
            yon = false;
        }
        else
        {
            platformPozisyon.x = -EkranHesaplayicisi.instance.Genislik / 2;
            yon = true;
        }
    }
}
