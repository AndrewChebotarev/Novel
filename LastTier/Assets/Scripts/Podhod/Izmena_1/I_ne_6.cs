using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class I_ne_6 : MonoBehaviour
{
    public Text textUI;

    private string text = "    Я не успел сделать и пары шагов, как поднялся сильный ветер, который понёс в мою сторону листья и пыль. ";

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