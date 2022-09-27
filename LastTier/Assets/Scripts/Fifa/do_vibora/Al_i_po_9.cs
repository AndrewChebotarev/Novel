using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Al_i_po_9 : MonoBehaviour
{
    public Text textUI;

    private string text = "    ~Я почему-то тоже не верю в это. Меня так уже пару раз разыгрывали. И, как видите, я стою перед вами, живой и здоровый.~";

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

