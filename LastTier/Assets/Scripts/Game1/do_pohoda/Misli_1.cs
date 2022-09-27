using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Misli_1 : MonoBehaviour
{
    public Text textUI;

    private string text = "    Обычный майский день.\n" +
        "\n"+
        "    На улице тепло, солнечно, лицо обдувает лёгкий ветерок.\n" +
        "\n"+
        "    Совсем скоро у нашего класса экзамены, потом выпускной, а потом и каникулы, где одни будут отдыхать и веселиться, другие – работать или усиленно искать учебные заведения, куда они пойдут после школы, а третьи уже всё для себя решили и будут плыть по течению.\n" +
        "\n"+
        "    Казалось, ничто не может омрачить этот прекрасный весенний день.";

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
