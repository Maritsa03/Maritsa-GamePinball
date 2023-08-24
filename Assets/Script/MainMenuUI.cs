using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class MainMenuUI : MonoBehaviour
{
    public Button playButton;
    public Button exitButton;
    public Button menuButton;
    public Button creditButton;

    private void Start()
    {
        playButton.onClick.AddListener(PlayGame);
        exitButton.onClick.AddListener(ExitGame);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Pinball_Game");
    }

    public void MenuGame()
    {
        SceneManager.LoadScene("mainMenu");
    }

    public void CreditGame()
    {
        SceneManager.LoadScene("creditMenu");
    }

    private void ExitGame()
    {
        Application.Quit();
    }
}
