﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Al_da_10 : MonoBehaviour
{
    public Text textUI;

    private string text = "    ~Да, не хватало ещё, чтобы мы засветились.~";

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