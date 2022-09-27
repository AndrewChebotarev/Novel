using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class I_sid_3 : MonoBehaviour
{
    public Text textUI;

    private string text = "    Я сидел в своей кровати и тяжело дышал, не совсем понимая, что здесь вообще происходит. Но вокруг меня была моя комната, не представляющая никакой опасности. Я успокоился и принял лежачее положение.";

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
