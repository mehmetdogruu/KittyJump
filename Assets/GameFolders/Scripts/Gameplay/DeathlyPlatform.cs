using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathlyPlatform : MonoBehaviour
{
    BoxCollider2D boxCollider2d;
    bool hareket;
    float randomHiz;
    float min, max;
    public bool Hareket
    {
        get
        {
            return hareket;
        }
        set
        {
            hareket = value;
        }
    }
    void Start()
    {
        boxCollider2d = GetComponent<BoxCollider2D>();
        randomHiz = Random.Range(0.5f, 1.0f);
        float objeGenislik = boxCollider2d.bounds.size.x / 2;
        if (transform.position.x > 0)
        {
            min = objeGenislik;
            max = EkranHesaplayicisi.instance.Genislik - objeGenislik;
        }
        else
        {
            min = -EkranHesaplayicisi.instance.Genislik + objeGenislik;
            max = -objeGenislik;
        }
    }

    void Update()
    {
        if (hareket)
        {
            float pingpongX = Mathf.PingPong(randomHiz * Time.time, max - min) + min;
            Vector2 pingpong = new Vector2(pingpongX, transform.position.y);
            transform.position = pingpong;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="Ayaklar")
        {
            FindObjectOfType<GameControl>().OyunuBitir();
        }
    }
}
