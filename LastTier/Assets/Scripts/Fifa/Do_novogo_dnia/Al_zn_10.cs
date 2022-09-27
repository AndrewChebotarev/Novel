using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Al_zn_10 : MonoBehaviour
{
    public Text textUI;

    private string text = "    ~Знаешь, тебе просто нужно поговорить с ним по этому поводу. Извини, что лезу не в своё дело, но у вас какие-то нездоровые отношения.";

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
