using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Misli_posle_klad_1 : MonoBehaviour
{
    public Text textUI;

    private string text = "    Бредя по улице, я не мог перестать размышлять о происходящем. Но теперь ко всему прочему прибавились мысли о новенькой.\n" +
        "\n" +
        "    Она наверняка до сих пор стоит рядом с могилой и что-то бормочет. Может, молитву читает? Да и почему она так себя ведёт? Я всё понимаю, но так долго скорбеть о смерти незнакомого человека...\n" +
        "\n" +
        "    Почему я так решил?\n" +
        "\n" +
        "    Потому что за эту неделю они и парой слов не перекинулись. А может, он был на неё за что-то обижен.\n" +
        "\n" +
        "    В любом случае, об этом я смогу узнать только от неё... если она вообще захочет мне что-то рассказать.\n" +
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
