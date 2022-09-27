using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Moge_5 : MonoBehaviour
{
    public Text textUI;

    private string text = "    Может, у девочек по расписанию физкультура, или они просто зашли что-то спросить. Однако в зале не было никого.В смысле, вообще никого, даже учителя физкультуры.";

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
