using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MamaDetector : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="Ayaklar")
        {
            GetComponentInParent<Mama>().MamaKapat();
            FindObjectOfType<Score>().MamaKazan();
        }
    }
}
