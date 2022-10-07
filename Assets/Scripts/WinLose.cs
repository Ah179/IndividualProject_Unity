using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinLose : MonoBehaviour
{
    private bool gameEnded = false;


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            Application.Quit();
        }
    }
    
    public void WinLevel()
    {
        if(gameEnded == false)
    {
        Debug.Log("You Win!");
        gameEnded = true;
        SceneManager.LoadScene("NextLevel");
    }
    }
    public void LoseLevel()
    {
        if(gameEnded == false)
        {
            Debug.Log("You Lose!");
            gameEnded = true;
            SceneManager.LoadScene("TryAgain");
        }
    }
}
