using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class I_vid_3 : MonoBehaviour
{
    public Text textUI;

    private string text = "    Я видел его старые фотографии в альбоме, но за столько лет, со школьной скамьи до самой смерти, он не изменился в своей красоте. Бабушка рассказывала, что в молодости он был парнем нарасхват, что было неудивительно.";

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
