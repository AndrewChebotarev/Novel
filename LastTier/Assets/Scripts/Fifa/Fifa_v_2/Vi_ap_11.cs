using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vi_ap_11 : MonoBehaviour
{
    public Text textUI;

    private string text = "    ~А потом я поняла цену всего этого. Ты можешь себе представить, что любое отклонение от идеала выливается в часовые лекции? Такими темпами я либо сойду с ума, либо мы с ним страшно поругаемся.~";

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
