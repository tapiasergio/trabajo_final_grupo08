using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //Metodo que permite cambiar la escena al nivel0
    public void LevelTwo()
    {
        SceneManager.LoadScene("StageBathroom");
    }

    //Metodo que permite cambiar la escena a instrucciones
    public void Play()
    {
        SceneManager.LoadScene("StageBathroom");
    }

    public void Instructions()
    {
        SceneManager.LoadScene("Instrucciones");
    }

    //Metodo que permite salir del juego
    public void Exit()
    {
        Application.Quit();
    }

    //Metodo que permite cambiar la escena a MainMenu
    public void ReturnMenu()
    {
        SceneManager.LoadScene("PlayScene");
    }
}
