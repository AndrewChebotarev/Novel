using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mnog_1 : MonoBehaviour
{
    public Text textUI;

    private string text = "    Многие уже успокоились и приняли смерть нашего друга, а некоторые, обнявшись, плакали. Кто-то пришёл в солнцезащитных очках, чтобы не показывать красные от слёз глаза.";

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
