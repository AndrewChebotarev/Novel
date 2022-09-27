using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Po_kor_11 : MonoBehaviour
{
    public Text textUI;

    private string text = "    По коридору в нашу сторону шла Виолетта. Изменения были заметны невооружённым глазом. Сегодня наша красавица пришла без тонны косметики на лице.";

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