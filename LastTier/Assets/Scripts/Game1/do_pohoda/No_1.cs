using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class No_1 : MonoBehaviour
{
    public Text textUI;

    private string text = "    Но было одно большое но: прямо сейчас я стою на кладбище и вместе со всеми провожаю в последний путь нашего одноклассника. Если бы неделю назад кто-нибудь сказал мне, что мой друг умрёт, я бы ни за что не поверил этим словам.";

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