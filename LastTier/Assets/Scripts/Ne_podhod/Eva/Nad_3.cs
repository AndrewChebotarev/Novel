using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nad_3 : MonoBehaviour
{
    public Text textUI;

    private string text = "    Надо бы найти новенькую, спросить её о том, что здесь творится. Мне кажется, что она что-то знает и не хочет говорить, потому и прячется. ";

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

