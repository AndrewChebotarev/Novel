using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class No_pro_3 : MonoBehaviour
{
    public Text textUI;

    private string text = "    Но пролежал я недолго. Просто мне надоело лежать. Я встал и обошёл свою комнату по периметру, убеждаясь, что всё на своих местах.";

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