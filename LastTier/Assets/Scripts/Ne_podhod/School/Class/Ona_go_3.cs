﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ona_go_3 : MonoBehaviour
{
    public Text textUI;

    private string text = "    Она говорила мне всё то, что я думал вчера вечером. Никто не мог понять, как это произошло. И никто не знал, что делать дальше.";

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

