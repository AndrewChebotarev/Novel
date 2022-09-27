using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Meni_10 : MonoBehaviour
{
    public Text textUI;

    private string text = "    Меня разбудил отец. Оказалось, что я проспал до семи часов. Быстро умывшись и позавтракав, я побежал в школу.";

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
