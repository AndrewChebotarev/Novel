using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mi_1 : MonoBehaviour
{
    public Text textUI;

    private string text = "    Мы хотели связать свою жизнь друг с другом, планировали поступить в один университет, на один факультет, как это принято во всех школьных романах.";

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