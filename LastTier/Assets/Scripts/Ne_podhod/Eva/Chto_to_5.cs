using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chto_to_5 : MonoBehaviour
{
    public Text textUI;

    private string text = "    Что-то мне подсказывает, что там ей делать нечего. В любом случае, если она в школе, то обязательно появится на уроках.";

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