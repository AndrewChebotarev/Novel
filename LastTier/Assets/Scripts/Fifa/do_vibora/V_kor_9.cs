using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class V_kor_9 : MonoBehaviour
{
    public Text textUI;

    private string text = "    В коридоре мы встретили Эндрю и Виолетту, и уже все вместе дошли до курилки. Там нас ждала остальная компания.";

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