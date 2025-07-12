using UnityEngine;

public class soundmanager : MonoBehaviour
{
    // Static instance for global access
    public static soundmanager Instance { get; private set; }

    [SerializeField] private AudioSource sfxSource;

    void Awake()
    {
        // Singleton setup
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

        // Ensure AudioSource exists
        if (sfxSource == null)
        {
            sfxSource = gameObject.AddComponent<AudioSource>();
            sfxSource.playOnAwake = false;
        }
    }

    /// <summary>
    /// Play a sound clip once
    /// </summary>
    public void PlaySound(AudioClip clip)
    {
        if (clip == null)
        {
            Debug.LogWarning("SoundManager: Tried to play a null AudioClip.");
            return;
        }

        sfxSource.PlayOneShot(clip);
    }
}
