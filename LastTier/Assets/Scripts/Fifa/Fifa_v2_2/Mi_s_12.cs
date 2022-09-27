using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mi_s_12 : MonoBehaviour
{
    public Text textUI;

    private string text = "    Мы с Йоханом пошли в сторону кабинета. С течением времени подтянулись остальные, и нас запустили в класс.";

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
