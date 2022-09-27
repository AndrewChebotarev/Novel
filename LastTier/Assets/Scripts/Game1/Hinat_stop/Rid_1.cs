using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rid_1 : MonoBehaviour
{
    public Text textUI;

    private string text = "    Но с самой первой секунды, как я её увидел, мне начало казаться, что мы знакомы. Хотя, она всё время сидела где-то в стороне ото всех, молчала, на контакт шла неохотно.";

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
