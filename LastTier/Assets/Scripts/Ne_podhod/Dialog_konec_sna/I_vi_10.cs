using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class I_vi_10 : MonoBehaviour
{
    public Text textUI;

    private string text = "    Я вытащил из шкафа первые попавшиеся вещи, оделся и, оставив записку на кровати, вылез через окно.";

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