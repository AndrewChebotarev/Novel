using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mu_vi_1 : MonoBehaviour
{
    public Text textUI;

    private string text = "    Мы вышли на задний двор, где у нас стоял небольшой домик, где хранится всякая всячина. Открыв его, я взял свой самокат, стоящий у самой двери.";

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
