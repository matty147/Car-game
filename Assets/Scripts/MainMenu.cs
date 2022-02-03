using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public static int NumberOfPlayers { get; private set; } = 1;

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void Player1()
    {
        Debug.Log("P1");
        NumberOfPlayers = 1;
    }

    public void Player2()
    {
        Debug.Log("P2");
        NumberOfPlayers = 2;
    }

    public void Player3()
    {
        Debug.Log("P3");
        NumberOfPlayers = 3;
    }

    public void Player4()
    {
        Debug.Log("P4   ");
        NumberOfPlayers = 4;
    }

    public void Mapmaintrack()
    {
        SceneManager.LoadScene("maintrack");
    }

    public void Mapmaintrack2()
    {
        SceneManager.LoadScene("maintrack2");
    }

    public void Mapmaintrack3()
    {
        SceneManager.LoadScene("maintrack3");
    }


}
