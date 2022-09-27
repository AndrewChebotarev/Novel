using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Al_nam_3 : MonoBehaviour
{
    public Text textUI;

    private string text = "    ~Нам всем сейчас тяжело. Он был и моим другом, и я тоже не знаю, как это могло случиться.~";

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