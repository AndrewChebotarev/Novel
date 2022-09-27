using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nosh_1 : MonoBehaviour
{
    public Text textUI;

    private string text = "    Ночью город менялся до неузнаваемости. Огни маленьких домиков уже потухли, и остались лишь огни большого города.";

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

