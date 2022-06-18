using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Rigidbody2D rb2d;
    Animator animator;
    Vector2 velocity;
    [SerializeField]
    float hiz;
    [SerializeField]
    float hizlanma;
    [SerializeField]
    float yavaslama;
    [SerializeField]
    float ziplamaGucu;
    [SerializeField]
    int ziplamalimiti = 3;
    int ziplamasayisi;
    Joystick joystick;
    JoystickButton joystickButton;
    bool zipliyor;
  

    

    void Awake()
    {
        joystickButton = FindObjectOfType<JoystickButton>();
        rb2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        joystick = FindObjectOfType<Joystick>();
        
    }

    void Update()
    {
#if UNITY_EDITOR
        KlavyeKontrol();
#else
                JoystickKontrol();
#endif
    }
    void KlavyeKontrol()
    {
        float hareketInput = Input.GetAxisRaw("Horizontal");
        Vector2 tempScale = transform.localScale;
        if (hareketInput>0)
        {
            velocity.x = Mathf.MoveTowards(velocity.x, hareketInput * hiz, hizlanma * Time.deltaTime);
            animator.SetBool("Walk2", true);
            tempScale.x = 0.6f;
        }else if (hareketInput < 0)
        {
            velocity.x = Mathf.MoveTowards(velocity.x, hareketInput * hiz, hizlanma * Time.deltaTime);
            animator.SetBool("Walk2", true);
            tempScale.x = -0.6f;

        }
        else
        {
            velocity.x = Mathf.MoveTowards(velocity.x, 0, yavaslama * Time.deltaTime);
            animator.SetBool("Walk2", false);

        }
        transform.localScale = tempScale;
        gameObject.transform.Translate(velocity * Time.deltaTime);

        if (Input.GetKeyDown("space"))
        {
            ZiplamayiBaslat();
        }
        if (Input.GetKeyUp("space"))
        {
            ZiplamayiDurdur();
        }
    }
    void JoystickKontrol()
    {
        float hareketInput = joystick.Horizontal;
        Vector2 tempScale = transform.localScale;
        if (hareketInput > 0)
        {
            velocity.x = Mathf.MoveTowards(velocity.x, hareketInput * hiz, hizlanma * Time.deltaTime);
            animator.SetBool("Walk2", true);
            tempScale.x = 0.6f;
        }
        else if (hareketInput < 0)
        {
            velocity.x = Mathf.MoveTowards(velocity.x, hareketInput * hiz, hizlanma * Time.deltaTime);
            animator.SetBool("Walk2", true);
            tempScale.x = -0.6f;

        }
        else
        {
            velocity.x = Mathf.MoveTowards(velocity.x, 0, yavaslama * Time.deltaTime);
            animator.SetBool("Walk2", false);

        }
        transform.localScale = tempScale;
        gameObject.transform.Translate(velocity * Time.deltaTime);
       
        if (joystickButton.tusaBasildi==true && zipliyor==false)
        {
            zipliyor = true;
            ZiplamayiBaslat();
        }
        if (joystickButton.tusaBasildi == false && zipliyor==true)
        {
            zipliyor = false;
            ZiplamayiDurdur();
        }
    }
    void ZiplamayiBaslat()
    {
        if (ziplamasayisi<ziplamalimiti)
        {
            FindObjectOfType<SesKontrol>().ZiplamaSes();
            rb2d.AddForce(new Vector2(0, ziplamaGucu), ForceMode2D.Impulse);
            animator.SetBool("Jump2", true);
            FindObjectOfType<SliderControl>().SliderValue(ziplamalimiti,ziplamasayisi);
        }
       
    }
    void ZiplamayiDurdur()
    {
        animator.SetBool("Jump2", false);
        ziplamasayisi++;
        FindObjectOfType<SliderControl>().SliderValue(ziplamalimiti, ziplamasayisi);
    }
    public void ZiplamayiSifirla()
    {
        ziplamasayisi = 0;
        FindObjectOfType<SliderControl>().SliderValue(ziplamalimiti, ziplamasayisi);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="Olum")
        {
            FindObjectOfType<GameControl>().OyunuBitir();
        }
    }
    public void OyunBitti()
    {
        Destroy(gameObject);
    }
}
