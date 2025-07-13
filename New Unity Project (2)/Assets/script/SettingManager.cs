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
        Time.timeScale = 0f; 
        settingsPanel.SetActive(true);
    }

    public void CloseSettings()
    {
        isPaused = false;
        Time.timeScale = 1f; 
        settingsPanel.SetActive(false);
    }

    public void GoToMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
    }


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

