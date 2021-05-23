using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour

 
{

    public GameObject MenuPause;
    public GameObject ButtonPause;
    public bool isPaused = false;   


    public void Pause()
    {
        


        if (isPaused)
        {
            
            MenuPause.SetActive(false);
            isPaused = false;
            Time.timeScale = 1;
            AudioListener.pause = false;
            ButtonPause.SetActive(true);
            
        }
        else
        {
            MenuPause.SetActive(true);
            isPaused = true;
            AudioListener.pause = true;
            Time.timeScale = 0;
            ButtonPause.SetActive(false);

        }

        

    }

    public void RestartScene()

    {
        MenuPause.SetActive(false);
        isPaused = false;
        //GameOverPainel.gameObject.SetActive(false);
        //restartButton.gameObject.SetActive(false);
        Time.timeScale = 1; // despausar jogo
        AudioListener.pause = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);



    }

    public void VoltaraoMenu()


    {
        AudioListener.pause = false;
        isPaused = false;
        SceneManager.LoadScene("Menu");

    }


}
