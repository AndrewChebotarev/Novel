using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Po_kor_10 : MonoBehaviour
{
    public Text textUI;

    private string text = "    По коридору в нашу сторону шла Виолетта. Как всегда, она была густо накрашена. Не понимаю, что в этом такого красивого. Как по мне, с этим макияжем она больше похожа на куклу, чем на человека.";

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
