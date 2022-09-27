using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Sam_pa_6 : MonoBehaviour
{
    public Text textUI;

    private string text = "    ~Пару недель назад он попросил у меня крупную сумму денег и пообещал вернуть, как только сможет. Ну, теперь уже не сможет, но я не об этом. Похоже, наш брат где-то очень сильно попал на бабки.~";

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
