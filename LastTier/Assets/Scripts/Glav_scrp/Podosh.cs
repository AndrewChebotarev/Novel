using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Podosh : MonoBehaviour
{
    public void PlayPressed()
    {
        SceneManager.LoadScene("Podosh");
    }
}