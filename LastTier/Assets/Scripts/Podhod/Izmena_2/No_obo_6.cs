using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class No_obo_6 : MonoBehaviour
{
    public Text textUI;

    private string text = "    Но, обойдя всю школу по второму кругу, я её не нашёл. Собственно, этого можно было ожидать.";

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
