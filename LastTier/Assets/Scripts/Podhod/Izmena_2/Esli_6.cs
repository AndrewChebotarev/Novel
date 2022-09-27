using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Esli_6 : MonoBehaviour
{
    public Text textUI;

    private string text = "    Если она знает моего друга, это поможет разобраться в происходящем. Интересно, а знала ли она о долгах?";

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

