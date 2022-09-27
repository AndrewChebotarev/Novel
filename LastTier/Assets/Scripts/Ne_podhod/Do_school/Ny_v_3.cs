using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ny_v_3 : MonoBehaviour
{
    public Text textUI;

    private string text = "    Ну вот, совсем другое дело. Закончив наводить на себе красоту, я вернулся к себе в комнату и начал собирать рюкзак.";

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
