using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Na_et_5 : MonoBehaviour
{
    public Text textUI;

    private string text = "    На этом уроке я обращал на всё происходящее в классе ещё меньше внимания, чем на предыдущем. Занят я был созерцанием видов из окна.";

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
