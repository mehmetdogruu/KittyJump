﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SliderControl : MonoBehaviour
{
    Slider slider;
    void Start()
    {
        slider = GetComponent<Slider>();
        slider.value = 1.0f;
    }
    public void SliderValue(int maxDeger,int gecerliDeger)
    {
        int sliderDeger = maxDeger - gecerliDeger;
        slider.maxValue = maxDeger;
        slider.value = sliderDeger;
    }

}
