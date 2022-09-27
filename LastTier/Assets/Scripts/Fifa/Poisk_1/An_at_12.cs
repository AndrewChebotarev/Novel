using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class An_at_12 : MonoBehaviour
{
    public Text textUI;

    private string text = "    ~Это я виноват в том, что случилось. Я и только я. Да, я видел в ней не человека, а средство для поддержания имиджа. И вот, как я за это наказан. Нужно было послушать её вчера, а я… Какая же я сволочь. Это я убил её…~";

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
