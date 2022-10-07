using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    // Start is called before the first frame update
    public void PlayGame()
    {
        Debug.Log("PLAY BUTTON CLICKED");
        SceneManager.LoadScene("sceneSample");
    }

    // Update is called once per frame
    public void QuitGame()
    {
        Debug.Log("Quit BUTTON CLICKED");
        Application.Quit();
    }

    public void SettingGame(){
        Debug.Log("SETTING CLICKED");
        SceneManager.LoadScene("Settings");
    }

    public void BackButton(){
        Debug.Log("Back Clicked");
        SceneManager.LoadScene("MainMenu");
    }
}
