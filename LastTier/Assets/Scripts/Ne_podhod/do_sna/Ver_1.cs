using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ver_1 : MonoBehaviour
{
    public Text textUI;

    private string text = "    Версия убийства отпадает сразу: в комнате, где нашли труп, не было ни следов борьбы, ни следов проникновения. Прохожие, что характерно, тоже ничего не видели, хотя район наш живёт 24 часа в сутки. ";

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
