using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Li_ti_5 : MonoBehaviour
{
    public Text textUI;

    private string text = "    ~Ты так мило краснеешь. Не бойся, ни у одного тебя с этим проблемы. Я тоже ещё не решила, кого приглашу. Но у нас ещё есть время подумать. Кончится май, начнутся экзамены, и только после них у нас будет выпускной.~";

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