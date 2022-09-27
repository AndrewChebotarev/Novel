using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Al_nez_10 : MonoBehaviour
{
    public Text textUI;

    private string text = "    ~Что она больше не хочет быть куклой. Хочет быть обычным человеком, как все, со своими достоинствами и недостатками. Говорила, что нет ничего плохого в том, чтобы не быть идеальным. Господи, как же она была права…~";

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
