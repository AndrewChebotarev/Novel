using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vi_a_9 : MonoBehaviour
{
    public Text textUI;

    private string text = "    ~А я думаю, что оно может быть связано между собой. По крайней мере, вероятность этого нельзя исключать.~";

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
