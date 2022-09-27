using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vi_i_10 : MonoBehaviour
{
    public Text textUI;

    private string text = "    ~Я понимаю, но… Я не знаю, что мне делать. Я пыталась с ним поговорить, но он никогда меня не слушает.";

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