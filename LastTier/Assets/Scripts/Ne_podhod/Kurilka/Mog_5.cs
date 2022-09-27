using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Mog_5 : MonoBehaviour
{
    public Text textUI;

    private string text = "    Может, узнаю у них что-нибудь интересное. Действительно, на заднем дворе, который мы ласково называли курилкой, уже собрался весь цвет нашего класса.";

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
