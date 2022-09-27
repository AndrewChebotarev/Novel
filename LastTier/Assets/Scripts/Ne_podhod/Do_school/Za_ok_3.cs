using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Za_ok_3 : MonoBehaviour
{
    public Text textUI;

    private string text = "    За окном было уже светло, а часы показывали 6:40. Скоро родители проснутся. Надо бы пойти умыться и привести себя в порядок.";

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