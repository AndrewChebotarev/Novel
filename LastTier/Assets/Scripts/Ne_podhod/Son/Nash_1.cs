using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nash_1 : MonoBehaviour
{
    public Text textUI;

    private string text = "    Наши отношения были замечательными, пусть и с некоторыми странностями. Она знала моих родителей, знала всех, с кем я общаюсь, но категорически не хотела рассказывать о себе.";

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