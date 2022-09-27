using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nek_9 : MonoBehaviour
{
    public Text textUI;

    private string text = "    Некоторое время мы просто стояли и молчали. Я видел, что она хочет что-то сказать, но не может. Её будто заклинило.";

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