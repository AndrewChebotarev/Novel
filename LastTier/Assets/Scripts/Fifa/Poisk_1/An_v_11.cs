using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class An_v_11 : MonoBehaviour
{
    public Text textUI;

    private string text = "    ~В общем, мы решили перестраховаться, и я разрешил ей не краситься. Но, видимо, она замазала прыщ на лице, и этим провалила задание.~";

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
