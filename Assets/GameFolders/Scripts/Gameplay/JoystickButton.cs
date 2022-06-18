using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class JoystickButton : MonoBehaviour,IPointerDownHandler, IPointerUpHandler
{
    [HideInInspector]
    public bool tusaBasildi;
    public void OnPointerDown(PointerEventData eventdata)
    {
        tusaBasildi = true;

    }
    public void OnPointerUp(PointerEventData eventdata)
    {
        tusaBasildi = false;
    }
}
