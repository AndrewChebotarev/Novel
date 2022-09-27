using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class On_11 : MonoBehaviour
{
    public Text textUI;

    private string text = "    Он повернул её голову, и я смог увидеть причину такой скованности. На щеке Виолетты, несмотря на явные попытки скрыть его косметикой, красовался прыщ.";

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
