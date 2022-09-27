using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kog_3 : MonoBehaviour
{
    public Text textUI;

    private string text = "    Когда всё было готово, я по привычке осмотрелся в комнате. Мой взгляд остановился на нашей семейной фотографии, висевшей на стене.";

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
