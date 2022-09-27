using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vi_raz_9 : MonoBehaviour
{
    public Text textUI;

    private string text = "    ~Ну, раз ты так говоришь… Хорошо. Просто… ты же знаешь, как мой парень заботится о моей внешности. Говорит, что не хочет, чтобы я позорила его, и заставляет постоянно краситься. У меня это уже как привычка.";

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
