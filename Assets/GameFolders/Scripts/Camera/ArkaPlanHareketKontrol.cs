using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArkaPlanHareketKontrol : MonoBehaviour
{
    float arkaPlanKonum;
    float mesafe = 10.24f;
    void Start()
    {
        arkaPlanKonum = transform.position.y;
    }

    void Update()
    {
        if (arkaPlanKonum+mesafe<Camera.main.transform.position.y)
        {
            ArkaPlanYerlestir();
        }
    }
    void ArkaPlanYerlestir()
    {
        arkaPlanKonum += (mesafe * 2);
        Vector2 yeniPozisyon = new Vector2(0, arkaPlanKonum);
        transform.position = yeniPozisyon;
    }
}
