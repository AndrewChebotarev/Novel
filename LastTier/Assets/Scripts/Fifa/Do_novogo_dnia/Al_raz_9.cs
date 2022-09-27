using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Al_raz_9 : MonoBehaviour
{
    public Text textUI;

    private string text = "    ~Ну разумеется. Выбрось ты это из головы. Рано или поздно этим шутникам надоест дурью маяться, и они перестанут. Если хочешь, сотри это сообщение.~";

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
