using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Poz_3 : MonoBehaviour

{
    public Text textUI;

    private string text = "    Позавтракав, я отправился в школу, догрызать гранит науки. Ещё пара недель, и я туда больше не вернусь. ";

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