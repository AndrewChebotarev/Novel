using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class I_op_10 : MonoBehaviour
{
    public Text textUI;

    private string text = "    Я опустился рядом с ним на колени и влепил ему звонкую пощёчину. Эндрю сложился почти до пола, но, что самое главное, перестал плакать.";

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