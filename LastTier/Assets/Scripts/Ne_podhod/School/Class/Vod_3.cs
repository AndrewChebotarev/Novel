using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vod_3 : MonoBehaviour
{
    public Text textUI;

    private string text = "    Войдя в класс, я обнаружил, что дошли сюда далеко не все. Лишь несколько человек, заняв задние парты, раскладывали учебники и о чём-то переговаривались.";

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
