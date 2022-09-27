using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Dom_misli_2 : MonoBehaviour
{
    public Text textUI;

    private string text = "    Я даже практикуюсь в создании одной такой игры. Простенькая аркада, которую только и можно сделать на моём ящике, но надо с чего-то начинать. Как это водится у многих создателей, название я придумаю в самом конце.\n" +
        "\n" +
        "    Взяв книгу, я мог остаться в ней на долгие часы. То же самое случилось и сейчас. Я читал до тех пор, пока мама не пришла ко мне в комнату и не сказала, что пора спать.\n" +
        "\n" +
        "    Оказавшись в постели, я попытался вспомнить свой вчерашний сон. Как бы я не напрягал память, я смог вспомнить лишь отрывки: как за мной пришли посреди ночи, как я гнал на самокате по городу… и, по большому счёту, всё.\n" +
        "\n";
      


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
