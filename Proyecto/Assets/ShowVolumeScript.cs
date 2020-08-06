﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowVolumeScript : MonoBehaviour
{
    Text percentageText;
    void Start()
    {
        percentageText = GetComponent<Text>();   
    }

    public void TextUpdate(float value)
    {
        percentageText.text = Mathf.RoundToInt(value * 100) + "%";
    }
}
