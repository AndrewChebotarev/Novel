using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ot_10 : MonoBehaviour
{
    public Text textUI;

    private string text = "    Открыв дверь, я увидел Эндрю, который сидел в углу под раковиной, закрыв лицо руками.";

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