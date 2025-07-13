using UnityEngine;
using UnityEngine.UI;

public class AudioVolumeController : MonoBehaviour
{
    public Slider volumeSlider;

    void Start()
    {
        // مقدار ذخیره شده رو از PlayerPrefs بگیر (اگر باشه)
        float savedVolume = PlayerPrefs.GetFloat("Volume", 1f);

        // تنظیم AudioListener روی مقدار ذخیره شده
        AudioListener.volume = savedVolume;

        // مقدار اسلایدر رو هم با اون هماهنگ کن
        if (volumeSlider != null)
        {
            volumeSlider.value = savedVolume;
            volumeSlider.onValueChanged.AddListener(SetVolume);
        }
    }

    public void SetVolume(float value)
    {
        AudioListener.volume = value;
        PlayerPrefs.SetFloat("Volume", value); // ذخیره‌سازی
    }
}
