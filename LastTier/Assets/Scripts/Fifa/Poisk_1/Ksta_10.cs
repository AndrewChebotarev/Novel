using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ksta_10 : MonoBehaviour
{
    public Text textUI;

    private string text = "    Кстати, её я тоже не видел среди нас. И тут вариантов не так много: либо она умудрилась заболеть перед экзаменами, либо целенаправленно не ходит в школу.";

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