using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Misli_posle_klad_3 : MonoBehaviour
{
    public Text textUI;

    private string text = "    Бредя по улице, я пытался осмыслить всё, что только что видел.\n" +
        "\n" +
        "    У меня появилось ещё больше вопросов, а вот ответов не прибавилось ни на грамм. Как логически объяснить внезапную пропажу новенькой, я решительно не знал. Не ветром же её сдуло.\n" +
        "\n" +
        "    И что она бормотала над могилой? Может, заклинание читала? \n" +
        "\n" +
        "    Такой же бред, но его становится уже слишком много.\n" +
        "\n" +
        "    Вечерело. Мимо меня проходили люди и проезжали машины. Их было не так много, как утром, многие всё ещё были на работе или на учебе. Всё как обычно. Ничего нового.\n" +
        "\n" +
        "    Наконец, показался мой дом.\n";


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