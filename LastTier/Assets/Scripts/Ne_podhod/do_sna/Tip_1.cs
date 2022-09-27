using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tip_1 : MonoBehaviour
{
    public Text textUI;

    private string text = "    Типичный такой контролируемый творческий беспорядок. Я посмотрел на часы. Половина восьмого. Это я так долго шёл до дома? Ну, допустим... Я, не раздеваясь, плюхнулся на кровать.";

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
