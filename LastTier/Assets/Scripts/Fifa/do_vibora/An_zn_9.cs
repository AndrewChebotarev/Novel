using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class An_zn_9 : MonoBehaviour
{
    public Text textUI;

    private string text = "    ~Мне тоже так кажется. Мало ли сейчас дурачков, которые прикалываются и на рандомные номера отправляют такие сообщения.~";

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
