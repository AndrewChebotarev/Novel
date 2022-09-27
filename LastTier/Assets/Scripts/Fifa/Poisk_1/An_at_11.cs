using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class An_at_11 : MonoBehaviour
{
    public Text textUI;

    private string text = "    ~Это моя вина, Алекс. Моя и только моя. Из-за меня у неё появились комплексы, она уже не воспринимала себя с недостатками.~";

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
