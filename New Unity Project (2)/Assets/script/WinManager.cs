using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinManager : MonoBehaviour
{
    public GameObject winPanel;    // پنل UI که شامل دکمه‌هاست
    public Text winText;           // متن "You Win!"
    private bool gameWon = false;

    void Start()
    {
        winPanel.SetActive(false); // در ابتدای بازی پنل مخفی باشه
        Time.timeScale = 1f;       // اطمینان از اینکه بازی در حالت اجراست
    }

    void Update()
    {
        if (deletingperacci.score >= 10 && !gameWon)
        {
            gameWon = true;
            ShowWinScreen();
        }

    }

    void ShowWinScreen()
    {
        winPanel.SetActive(true);       // پنل رو فعال کن
        winText.text = "You Win!";      // متن برنده شدن
        Time.timeScale = 0f;            // بازی رو متوقف کن
    }

    // دکمه‌ها این توابع رو صدا بزنن:

    public void OnNextLevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void OnRetry()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void OnMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu"); // اطمینان حاصل کن صحنه منو وجود داره
    }
}
