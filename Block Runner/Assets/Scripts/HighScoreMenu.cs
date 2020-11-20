using UnityEngine;
using UnityEngine.SceneManagement;

public class HighScoreMenu : MonoBehaviour
{

    public static bool GameIsPaused = false;
    public GameObject HighScoreMenuUI;
    public GameObject PauseMenuUI;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                BackToGame();
            }
            else
            {
                HighScore();

            }
        }
    }

    public void BackToGame()
    {
        
        HighScoreMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    void HighScore()
    {
        PauseMenuUI.SetActive(false);
        HighScoreMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    void LoadHighScore()
    {
        SceneManager.LoadScene("High");
    }
  
}
