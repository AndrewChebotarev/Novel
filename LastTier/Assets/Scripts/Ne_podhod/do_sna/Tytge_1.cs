using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tytge_1 : MonoBehaviour
{
    public Text textUI;

    private string text = "    Тут же передо мной предстала недавняя картина: стоящая над могилой новенькая, которая шепчет не понятно что.";

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
