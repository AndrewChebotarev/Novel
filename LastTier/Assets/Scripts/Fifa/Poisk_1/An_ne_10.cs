using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class An_ne_10 : MonoBehaviour
{
    public Text textUI;

    private string text = "    ~Не оправдывай меня! Это я во всём виноват! Я…~";

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