using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ed_ny_9 : MonoBehaviour
{
    public Text textUI;

    private string text = "    ~Ну, мы пальцем у виска покрутили, посмеялись, да и забыли про это. А теперь я вот, вспомнил. Может, одно с другим как-то связано?~";

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

