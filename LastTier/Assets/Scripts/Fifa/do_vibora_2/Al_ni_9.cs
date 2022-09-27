using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Al_ni_9 : MonoBehaviour
{
    public Text textUI;

    private string text = "    ~Ничего страшного. Я понимаю, ты хочешь узнать, что случилось. Но этим должна заниматься полиция. А она не любит, когда ей мешают.~";

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
