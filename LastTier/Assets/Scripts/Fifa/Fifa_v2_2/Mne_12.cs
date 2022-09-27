using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mne_12 : MonoBehaviour
{
    public Text textUI;

    private string text = "    Мне кажется, что это ничем хорошим не кончится. Надо будет поговорить с Эндрю по поводу его истерик. ";

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
