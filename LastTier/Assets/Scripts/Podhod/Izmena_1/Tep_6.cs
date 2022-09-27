using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tep_6 : MonoBehaviour
{
    public Text textUI;

    private string text = "    Теперь я и правда остался на кладбище совсем один. Чувствуя, что здесь что-то не так, я поспешил удалиться.";

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
