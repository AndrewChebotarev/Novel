using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bred_6 : MonoBehaviour
{
    public Text textUI;

    private string text = "    Нет, это какой-то бред. Ну не может такая тихая девочка быть замешана в убийстве. Скорее всего, это просто череда совпадений.";

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

