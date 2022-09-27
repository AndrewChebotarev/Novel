using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sz_10 : MonoBehaviour
{
    public Text textUI;

    private string text = "    Сзади к нам подошёл учитель и объявил, что сегодня у нас не будет уроков, и что мы можем идти домой. Эту новость мы восприняли с некоторым облегчением.";

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