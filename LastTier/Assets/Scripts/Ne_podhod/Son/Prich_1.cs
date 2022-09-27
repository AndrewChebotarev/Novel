using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Prich_1 : MonoBehaviour
{
    public Text textUI;

    private string text = "    Причину такой скрытности она не называла. Ни я, ни моим друзьям, ни даже руководству школы не было доподлинно известно о ней и её семье. ";

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
