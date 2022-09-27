using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Al_ved_9 : MonoBehaviour
{
    public Text textUI;

    private string text = "    ~А ведь это мысль. Да, ты права, мы можем много чего узнать. Хорошо, я помогу тебе.~";

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

