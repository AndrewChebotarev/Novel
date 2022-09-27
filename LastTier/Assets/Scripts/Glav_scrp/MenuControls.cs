using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControls : MonoBehaviour
{
    public void PlayPressed()
    {
        SceneManager.LoadScene("Game");
    }
    public void BackMenu()
    {
        SceneManager.LoadScene("Menu");
    }
   
    public void ExitPressed()
    {
        Application.Quit();
        Debug.Log("Exit pressed!");
    }
  
}
   
