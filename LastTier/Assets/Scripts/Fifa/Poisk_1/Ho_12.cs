using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ho_12 : MonoBehaviour
{
    public Text textUI;

    private string text = "    Хорошо, что он понял все свои ошибки. Плохо, что понял их слишком поздно. Однако говорить это сейчас – не самая лучшая идея. Нужно отвести Эндрю к остальным.";

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
