using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vi_vot_9 : MonoBehaviour
{
    public Text textUI;

    private string text = "    ~Вот я и подумала, что если взять телефон и посмотреть, какое задание ему отправили, то так мы сможем построить логическую цепочку и понять, что произошло.~";

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