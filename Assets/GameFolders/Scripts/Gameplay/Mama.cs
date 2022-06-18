using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mama : MonoBehaviour
{
    [SerializeField]
    GameObject mama;
    
    public void MamaAc()
    {
        mama.SetActive(true);
    }
    public void MamaKapat()
    {
        mama.SetActive(false);
    }
}
