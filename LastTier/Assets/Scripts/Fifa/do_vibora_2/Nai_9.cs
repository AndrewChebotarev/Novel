using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nai_9 : MonoBehaviour
{
    public Text textUI;

    private string text = "    Найти нужный не составило труда, мы все хорошо помнили, где находится ящик. А я, вдобавок ко всему прочему, помнил, где обычно лежал запасной ключ.";

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