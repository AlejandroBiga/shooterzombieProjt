using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorScenas : MonoBehaviour
{


    private void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }


    


    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene(0);
    }


    

    public void QuitGame()
    {
        Application.Quit();
    }
}
