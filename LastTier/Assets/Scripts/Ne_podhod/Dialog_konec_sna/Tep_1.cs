using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tep_1 : MonoBehaviour
{
    public Text textUI;

    private string text = "    Теперь у них абсолютная монополия на привлечение к себе восторженных взглядов и местных жителей, и туристов.";

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
