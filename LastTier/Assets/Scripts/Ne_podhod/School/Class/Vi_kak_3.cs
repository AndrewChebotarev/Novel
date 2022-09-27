using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vi_kak_3 : MonoBehaviour
{
    public Text textUI;

    private string text = "    ~Как… как же так? Но ведь это невозможно. Нельзя просто так, на ровном месте, умереть от болезни сердца. Он же был здоров, даже в соревнованиях участвовал. С проблемами с сердцем его бы просто до них не допустили. ~";

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
