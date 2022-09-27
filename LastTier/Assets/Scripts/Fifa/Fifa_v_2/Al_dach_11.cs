using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Al_dach_11 : MonoBehaviour
{
    public Text textUI;

    private string text = "    ~Да что за глупости? Виола, ты интересная, умная девушка. Главное – это не то, как ты выглядишь, а то, какой ты человек. Да и потом, ты всегда была красивой и без косметики.~";

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
