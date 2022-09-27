using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Sam_kak_5 : MonoBehaviour
{
    public Text textUI;

    private string text = "    ~Как и все мы не можем поверить. Ребят, мне кажется, или тут всё намного сложнее. ~";

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
