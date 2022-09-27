using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Al_aga_5 : MonoBehaviour
{
    public Text textUI;

    private string text = "    ~Ага, накормили, и никто об этом не знает. Сомневаюсь. Да и потом, он в последнее время кроме школы никуда не ходил, а постоянно сидел дома. То есть, с ним контактировали только мы и его родители. И никто из вышеназванных в его смерти не заинтересован.~";

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

