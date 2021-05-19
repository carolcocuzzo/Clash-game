using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1; // pausar jogo
        //AudioListener.pause = false;
    }
    

    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }   

    
    //public AudioMixer audioMixer;

   
}
