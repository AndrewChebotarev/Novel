using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vi_no_5 : MonoBehaviour
{
    public Text textUI;

    private string text = "    ~Но зачем? Зачем ему было травить себя? Он что, экзаменов боялся? Я, конечно, могу чего-то не знать, но мне всегда казалось, что он никогда об этом не беспокоился.~";

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

