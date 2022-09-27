using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vi_dym_11 : MonoBehaviour
{
    public Text textUI;

    private string text = "    ~Думаешь, я не пыталась? Он и слушать меня не хочет. А я… я не знаю, что мне делать. Ведь он прав. Я действительно не нужна никому, кроме него.~";

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
