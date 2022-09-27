using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stran_2 : MonoBehaviour
{
    public Text textUI;

    private string text = "    Странная она... Нет, не из-за изолированности от всего коллектива, и даже не из-за того случая на кладбище. Я научился понимать людей, различать своих и чужих. И есть в этой новенькой что-то... не такое.";

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
