using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class No_r_1 : MonoBehaviour
{
    public Text textUI;

    private string text = "    Но реальность – жестокая штука, она действует независимо от того, что мы хотим и что делаем. И что бы ты не делал, прошлое вернуть не получится. Остаётся лишь настоящее и неизвестное будущее.";

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