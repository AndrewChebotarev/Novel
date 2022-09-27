using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rad_1 : MonoBehaviour
{
    public Text textUI;

    private string text = "    Рядом с надгробием стояла новенькая и что-то бормотала себе под нос. Она пришла к нам всего неделю назад, так что я не успел узнать её достаточно хорошо. ";

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
