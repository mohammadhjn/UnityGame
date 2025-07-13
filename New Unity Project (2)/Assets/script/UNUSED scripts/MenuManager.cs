using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject mainMenuPanel;
    public GameObject gameSelectionPanel;
    public GameObject settingsPanel;

    void Start()
    {
        ShowMainMenu();
    }

    public void ShowMainMenu()
    {
        mainMenuPanel.SetActive(true);
        gameSelectionPanel.SetActive(false);
        settingsPanel.SetActive(false);
    }

    public void ShowGameSelection()
    {
        mainMenuPanel.SetActive(false);
        gameSelectionPanel.SetActive(true);
    }

    public void ShowSettings()
    {
        mainMenuPanel.SetActive(false);
        settingsPanel.SetActive(true);
    }

    public void OpenGithub()
    {
        Application.OpenURL("https://github.com/YourUsername"); // لینک گیتهاب خودت رو جایگزین کن
    }

    public void QuitGame()
    {
        Application.Quit(); // فقط روی بیلد نهایی کار می‌کنه
    }
}
