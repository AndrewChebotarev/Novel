using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Al_gl_10 : MonoBehaviour
{
    public Text textUI;

    private string text = "    ~Главное – это то, какой ты человек, а не как ты выглядишь. Да и потом, ты всегда была красивой и без этой косметики.";

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