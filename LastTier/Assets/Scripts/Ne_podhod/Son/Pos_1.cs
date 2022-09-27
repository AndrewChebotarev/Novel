using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pos_1 : MonoBehaviour
{
    public Text textUI;

    private string text = "    После несчётного количества попыток я так и не смог узнать причину нашего разрыва. С тех пор мы стали реже общаться. Разве что в школе мы задавали друг другу дежурные вопросы вроде «как дела?», «какой сейчас урок?» или «кто из наших сегодня не придёт?».";

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
