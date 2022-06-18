using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    public GameObject joystick;
    public GameObject oyunBittiPanel;
    public GameObject ziplamaButonu;
    public GameObject tabela;
    public GameObject slider;
    public GameObject menuButonu;




    void Start()
    {
        oyunBittiPanel.SetActive(false);
        UIAc();
    }

    public void OyunuBitir()
    {
        FindObjectOfType<SesKontrol>().GameOverSes();
        oyunBittiPanel.SetActive(true);
        FindObjectOfType<PlayerMove>().OyunBitti();
        FindObjectOfType<Score>().OyunBitti();
        FindObjectOfType<KameraHareket>().OyunBitti();
        UIKapat();
        
    }
    public void AnaMenuyeDon()
    {
        SceneManager.LoadScene("Menu");
    }
    public void TekrarOyna()
    {
        SceneManager.LoadScene("Oyun");
    }
    void UIAc()
    {
        joystick.SetActive(true);
        slider.SetActive(true);
        tabela.SetActive(true);
        menuButonu.SetActive(true);
        ziplamaButonu.SetActive(true);
      

    }
    void UIKapat()
    {
        joystick.SetActive(false);
        slider.SetActive(false);
        tabela.SetActive(false);
        menuButonu.SetActive(false);
        ziplamaButonu.SetActive(false);
    }
}
