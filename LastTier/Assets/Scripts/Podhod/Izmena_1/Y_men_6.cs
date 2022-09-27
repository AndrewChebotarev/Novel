using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Y_men_6 : MonoBehaviour
{
    public Text textUI;

    private string text = "    У меня появилось ещё больше вопросов, а вот ответов не прибавилось ни на грамм. Как логически объяснить внезапную пропажу новенькой, я решительно не знал. Не ветром же её сдуло.";

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