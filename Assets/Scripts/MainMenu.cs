using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

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
    }

    public void Player2()
    {
        Debug.Log("P2");
    }

    public void Player3()
    {
        Debug.Log("P3");
    }

    public void Player4()
    {
        Debug.Log("P4");
    }




}
