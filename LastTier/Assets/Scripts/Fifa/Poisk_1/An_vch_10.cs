using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class An_vch_10 : MonoBehaviour
{
    public Text textUI;

    private string text = "    ~Вчера она пришла ко мне… и рассказала о сообщении. Но я её не слушал… Я думал, что это очередной розыгрыш, бред. Но… а оно вот так обернулось… Это моя вина, Алекс. Моя и только моя. Если бы не такое отношение к ней с моей стороны, она бы всё ещё была жива.~";

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