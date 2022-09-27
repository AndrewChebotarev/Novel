using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Experimental.UIElements;

public class Settings : MonoBehaviour
{
    public AudioMixer am;

    public void AudioVolume(float sliderValue)
    {
        am.SetFloat("masterVolume", sliderValue);
    }

    public void FullScreenToggle()
    {
        Screen.fullScreen = !Screen.fullScreen;
        Screen.fullScreen = Screen.fullScreen;
    }

}
