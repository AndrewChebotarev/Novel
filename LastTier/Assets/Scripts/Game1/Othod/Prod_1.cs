using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Prod_1 : MonoBehaviour
{
    public Text textUI;

    private string text = "    Продолжая размышлять о всей странности этой трагической ситуации, я не заметил, как остался стоять на кладбище совсем один.";

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
