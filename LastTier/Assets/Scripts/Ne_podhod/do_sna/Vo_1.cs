using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vo_1 : MonoBehaviour
{
    public Text textUI;

    private string text = "    Войдя внутрь, я понял, что дома я нахожусь один. Что ж, тем лучше. Никто не будет мне мешать.";

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
