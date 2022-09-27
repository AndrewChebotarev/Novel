using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Al_ti_9 : MonoBehaviour
{
    public Text textUI;

    private string text = "    ~Ты знаешь, это как-то… неправильно, что ли. Копаться в вещах покойника… нет, я на это не согласен. Тем более, что скоро за этими вещами придут его родители или полиция. А если они обнаружат вскрытый шкафчик, да ещё и наши отпечатки…~";

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
