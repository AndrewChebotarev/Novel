using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Al_dat_11 : MonoBehaviour
{
    public Text textUI;

    private string text = "    ~Да, такие отношения трудно назвать здоровыми. Но мне всё же кажется, что вам надо сесть и поговорить об этом, как взрослым людям.~";

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
