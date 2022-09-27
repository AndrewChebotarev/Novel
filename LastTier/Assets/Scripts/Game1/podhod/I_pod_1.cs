using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class I_pod_1 : MonoBehaviour
{
    public Text textUI;

    private string text = "    Я подошёл и внимательно посмотрел на фотографию своего друга.";

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
