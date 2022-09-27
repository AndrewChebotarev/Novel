using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ed_kak_9 : MonoBehaviour
{
    public Text textUI;

    private string text = "    ~Как я понял, с каким-то заданием. Само задание я прочитать не успел, но в конце говорилось, что невыполнение задания карается смертью.~";

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
