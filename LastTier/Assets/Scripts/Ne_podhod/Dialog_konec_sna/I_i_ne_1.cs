﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class I_i_ne_1 : MonoBehaviour
{
    public Text textUI;

    private string text = "    Я и не заметил, как выехал вперед.";

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