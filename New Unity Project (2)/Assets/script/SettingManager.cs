using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingManager : MonoBehaviour
{
    public GameObject settingsPanel;

    private bool isPaused = false;

    void Start()
    {
        settingsPanel.SetActive(false);
    }

    public void OpenSettings()
    {
        isPaused = true;
        Time.timeScale = 0f; // متوقف کردن بازی
        settingsPanel.SetActive(true);
    }

    public void CloseSettings()
    {
        isPaused = false;
        Time.timeScale = 1f; // ادامه بازی
        settingsPanel.SetActive(false);
    }

    public void GoToMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0); // منوی اصلی
    }

    // این تابع اختیاریه برای بستن با دکمه ESC
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
                CloseSettings();
            else
                OpenSettings();
        }
    }
}

