using UnityEngine;
using UnityEngine.UI;

public class ThemeManager : MonoBehaviour
{
    public Color lightBackground;
    public Color darkBackground;

    public Color lightText;
    public Color darkText;

    public Image[] backgrounds;
    public Text[] texts;

    private bool isDarkMode = false;

    void Start()
    {
        isDarkMode = PlayerPrefs.GetInt("darkmode", 0) == 1;
        ApplyTheme();
    }

    public void ToggleDarkMode()
    {
        isDarkMode = !isDarkMode;
        PlayerPrefs.SetInt("darkmode", isDarkMode ? 1 : 0);
        ApplyTheme();
    }

    void ApplyTheme()
    {
        Color bgColor = isDarkMode ? darkBackground : lightBackground;
        Color textColor = isDarkMode ? darkText : lightText;

        foreach (Image img in backgrounds)
            img.color = bgColor;

        foreach (Text txt in texts)
            txt.color = textColor;
    }
}

