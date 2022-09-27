using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Eh_7 : MonoBehaviour
{
    public Text textUI;

    private string text = "    Ещё один учебный день остался позади. Толпа учеников, образовавшаяся везде, где только можно, постепенно рассасывалась, все расходились по домам. Не желая толкаться со всеми в коридоре, я остался в классе.";

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