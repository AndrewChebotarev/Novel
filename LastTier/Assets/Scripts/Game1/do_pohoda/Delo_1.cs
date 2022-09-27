using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Delo_1 : MonoBehaviour
{
    public Text textUI;

    private string text = "    Дело в том, что я знал его много лет, и всё это время у него вообще не было проблем со здоровьем. Чёрт побери, мы много раз вместе проходили медкомиссию. И ни одна из них не выявила у него даже минимальных отклонений от нормы, не говоря уже про нарушения в работе сердца.";

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