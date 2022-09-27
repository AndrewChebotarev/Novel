using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class An_vch_11 : MonoBehaviour
{
    public Text textUI;

    private string text = "    ~Вчера она пришла ко мне… очень нервная, даже чем-то напуганная. Когда я попытался выяснить, что случилось, она сказала… сказала, что больше не хочет так жить.~";

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
