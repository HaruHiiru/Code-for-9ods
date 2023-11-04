using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class mainMenu : MonoBehaviour
{
    public GameObject confirmationDialog;

    public void playButton()
    {
        SceneManager.LoadScene("Intro");
    }

    public void exitButton() 
    {
        Application.Quit();
    }

    public void dialogPop()
    {
        confirmationDialog.SetActive(true);
    }

    public void cancelExit()
    {
        confirmationDialog.SetActive(false);
    }
}
