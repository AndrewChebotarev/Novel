using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class I_re_3 : MonoBehaviour
{
    public Text textUI;

    private string text = "    Я решил поискать её в коридорах школы. Но сколько бы я ни ходил и кого бы ни спрашивал, результата это не дало.";

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