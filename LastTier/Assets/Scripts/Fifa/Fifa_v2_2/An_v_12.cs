﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class An_v_12 : MonoBehaviour
{
    public Text textUI;

    private string text = "    ~В следующий раз постарайся лечь пораньше, дорогая! И что теперь? Будешь весь день ходить с этим ужасом?~";

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