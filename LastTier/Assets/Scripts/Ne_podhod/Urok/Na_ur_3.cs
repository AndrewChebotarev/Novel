using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Na_ur_3 : MonoBehaviour
{
    public Text textUI;

    private string text = "    На уроке не происходило ничего интересного. Учитель объяснял новый материал, кого-то о чём-то спрашивал, а ему отвечали. Спрашивали в основном тех, у кого не хватало оценок, или тех, чьи оценки не устраивали лично учителя.";

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