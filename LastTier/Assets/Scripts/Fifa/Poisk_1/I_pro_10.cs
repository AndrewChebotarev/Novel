using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class I_pro_10 : MonoBehaviour
{
    public Text textUI;

    private string text = "    Я продолжительное время наматывал круги по школе, не понимая, где он может быть. Сразу вспомнился вчерашний день, когда я искал Еву.";

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