using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kak_t_3 : MonoBehaviour
{
    public Text textUI;

    private string text = "    Как только я оказался около доски, ко мне тут же подошла наша незаменимая во всех отношениях активистка.";

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