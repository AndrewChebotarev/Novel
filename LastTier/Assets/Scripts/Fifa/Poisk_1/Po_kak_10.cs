using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Po_kak_10 : MonoBehaviour
{
    public Text textUI;

    private string text = "    Как мне кажется, вот так она выглядит намного симпатичнее. И чего Эндрю не нравится в её естественной красоте?";

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