using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Viol_9 : MonoBehaviour
{
    public Text textUI;

    private string text = "    Виолетта достала телефон… и замерла. Некоторое время она стояла так, смотря в экран телефона и, видимо, что-то хорошенько обдумывая.";

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
