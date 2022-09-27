using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Io_da_10 : MonoBehaviour
{
    public Text textUI;

    private string text = "    ~Да брату что-то в библиотеке понадобилось, вот он и решил пораньше выйти, чтобы до уроков успеть. А я так, за компанию. Что мне одному дома делать?~";

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