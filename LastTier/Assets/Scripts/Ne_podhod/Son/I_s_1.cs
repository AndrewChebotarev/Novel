using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class I_s_1 : MonoBehaviour
{
    public Text textUI;

    private string text = "    И сейчас я был очень сильно удивлён, что спустя столько времени Лизи решила навестить меня, да ещё и глубокой ночью.";

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
