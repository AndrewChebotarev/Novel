using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sna_1 : MonoBehaviour
{
    public Text textUI;

    private string text = "    Сначала мы неспешно ехали по освещенной улице и общались на отвлеченные темы. Потом мы просто молчали, глядя по сторонам и любуясь огнями небоскребов в центре города, неоновыми вывесками, рекламными билбордами и прочими прелестями цивилизации. ";

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

