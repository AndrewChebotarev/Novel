using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vi_tsh_11 : MonoBehaviour
{
    public Text textUI;

    private string text = "    ~Ты же знаешь, как он обо мне «заботится». Каждый раз, когда мы остаёмся одни, он напоминает мне о том, что я должна быть идеальной, не позорить его. Говорит, что я больше никому не нужна. Сначала я не придавала этому значения. Да мне и самой хотелось быть идеальной.~";

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
