using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class I_zam_1 : MonoBehaviour
{
    public Text textUI;

    private string text = "    Я заметил, как мои одноклассники начали по очереди складывать цветы к надгробию. Они медленно подходили, клали цветы, что-то шептали и вставали поближе к выходу с кладбища.";

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
