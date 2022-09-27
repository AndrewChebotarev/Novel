using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chto_3 : MonoBehaviour
{
    public Text textUI;

    private string text = "    Что-то отталкивало его от этого места и людей, которые с ним связаны. Интересно, что бы он сказал на то, что меня записали в эту школу, если бы дожил до того момента.";

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
