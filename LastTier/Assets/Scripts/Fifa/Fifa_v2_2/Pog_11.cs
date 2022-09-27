using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pog_11 : MonoBehaviour
{
    public Text textUI;

    private string text = "    Позже всех пришла Виолетта. Зайдя в класс, она поспешила за последнюю парту. Но перед тем, как она успела спрятаться за стопкой книжек, я увидел на её лице… ";

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
