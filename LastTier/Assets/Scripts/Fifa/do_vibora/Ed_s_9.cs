using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ed_s_9 : MonoBehaviour
{
    public Text textUI;

    private string text = "    ~Сейчас расскажу. В общем, незадолго до смерти Никита пригласил меня к себе. Ну, мы сидели, общались, чай пили… и ему на телефон пришло сообщение.~";

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