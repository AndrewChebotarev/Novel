using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class San_na_10 : MonoBehaviour
{
    public Text textUI;

    private string text = "    Народ, а вам не кажется, что здесь кого-то не хватает?";

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
