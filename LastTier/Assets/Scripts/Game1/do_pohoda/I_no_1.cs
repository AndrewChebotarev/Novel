﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class I_no_1 : MonoBehaviour
{
    public Text textUI;

    private string text = "    Я не готов поверить, что абсолютно здоровый человек в одночасье может перестать быть таковым без видимых на то причин.";

    void Start()
    {
        StartCoroutine("showText", text);
    }

    IEnumerator showText(string text)
    {
        int i = 0;
        while (i <= text.Length)
        {
            textUI.text = text.Substring(0, i);
            i++;

            yield return new WaitForSeconds(0.06f);
        }
    }
}