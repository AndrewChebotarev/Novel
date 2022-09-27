using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Int_3 : MonoBehaviour
{
    public Text textUI;

    private string text = "    Интересно, что он учился в той же школе, что и я сейчас. Однако после выпуска он ни разу не приходил туда, не посещал встречи выпускников.";

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
