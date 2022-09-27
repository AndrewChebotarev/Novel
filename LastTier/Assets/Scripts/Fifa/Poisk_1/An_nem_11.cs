using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class An_nem_11 : MonoBehaviour
{
    public Text textUI;

    private string text = "    ~Не могла показаться перед людьми. Если бы не такое отношение к ней с моей стороны, она бы всё ещё была жива.~";

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
