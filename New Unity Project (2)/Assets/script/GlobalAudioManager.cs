using UnityEngine;
using UnityEngine.UI;

public class GlobalAudioManager : MonoBehaviour
{
    public Button muteButton;
    public Text muteButtonText;

    private bool isMuted = false;

    void Start()
    {
        UpdateButtonText();
    }

    public void ToggleMute()
    {
        isMuted = !isMuted;
        AudioListener.volume = isMuted ? 0f : 1f;
        UpdateButtonText();
    }

    void UpdateButtonText()
    {
        if (muteButtonText != null)
            muteButtonText.text = isMuted ? "🔇 Unmute" : "🔊 Mute";
    }
}
