using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class I_pri_3 : MonoBehaviour
{
    public Text textUI;

    private string text = "    Я приобнял её за плечи и приблизил к себе. Это подействовало: она не заплакала, а с глаз исчезли выступившие слёзы.";

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