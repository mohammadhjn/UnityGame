using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinManager : MonoBehaviour
{
    public GameObject winPanel;
    public Text winText;
    public Text targetScoreText;
    public GameObject nextLevelButton;

    private int targetScore = 100;
    private bool gameWon = false;

    void Start()
    {
        winPanel.SetActive(false);
        Time.timeScale = 1f;

        if (PlayerPrefs.HasKey("TargetScore"))
            targetScore = PlayerPrefs.GetInt("TargetScore");
        else
            targetScore = 100;

        if (targetScoreText != null)
            targetScoreText.text = "Target: " + targetScore.ToString();

        Debug.Log("Target Score is: " + targetScore);
    }

    void Update()
    {
        if (deletingperacci.score >= targetScore && !gameWon)
        {
            gameWon = true;
            ShowWinScreen();
        }
    }

    void ShowWinScreen()
    {
        winPanel.SetActive(true);
        winText.text = "You Win!";
        Time.timeScale = 0f;

        int currentLevel = PlayerPrefs.GetInt("Level", 1);
        if (nextLevelButton != null)
        {
            nextLevelButton.SetActive(currentLevel < 5);
        }
    }

    public void OnNextLevel()
    {
        int currentLevel = PlayerPrefs.GetInt("Level", 1);

        if (currentLevel < 5)
        {
            int nextLevel = currentLevel + 1;
            int nextTargetScore = 20 * nextLevel;

            PlayerPrefs.SetInt("Level", nextLevel);
            PlayerPrefs.SetInt("TargetScore", nextTargetScore);

            deletingperacci.score = 0;
            Time.timeScale = 1f;
            SceneManager.LoadScene(2);
        }
        else
        {
            deletingperacci.score = 0;
            Time.timeScale = 1f;
            nextLevelButton.SetActive(false);
        }
    }

    public void OnRetry()
    {
        deletingperacci.score = 0;
        Time.timeScale = 1f;
        SceneManager.LoadScene(2);
    }

    public void OnMainMenu()
    {
        deletingperacci.score = 0;
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
}
