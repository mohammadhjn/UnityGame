using UnityEngine;
using UnityEngine.UI;

public class MuteButtonController : MonoBehaviour
{
    public Text buttonText;

    void Start()
    {
        UpdateText();
    }

    public void OnMuteButtonClick()
    {
        if (BackgroundMusicManager.Instance != null)
        {
            BackgroundMusicManager.Instance.ToggleMute();
            UpdateText();
        }
    }

    void UpdateText()
    {
        if (BackgroundMusicManager.Instance != null)
        {
            bool isMuted = BackgroundMusicManager.Instance.IsMuted();
            buttonText.text = isMuted ? "🔇 BG Unmute" : "🔊 BG Mute";
        }
    }
}
