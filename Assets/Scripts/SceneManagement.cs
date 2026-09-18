using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        
    }

    void Game()
    {
        SceneManager.LoadScene("Game");
    }

    void Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
}
