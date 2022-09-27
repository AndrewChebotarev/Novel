using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Menu : MonoBehaviour
{

    public bool isOpened = false;

    public float volume = 0;

    public bool isFullscreen = false;

    public AudioMixer audioMixer;



    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))

        {
            isOpened = !isOpened;

            GetComponent<Canvas>().enabled = isOpened;

        }
    }

}