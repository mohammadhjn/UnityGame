using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public void LoadLevel(int level)
    {
        int score = 20 * level;

        PlayerPrefs.SetInt("Level", level);
        PlayerPrefs.SetInt("TargetScore", score);

        SceneManager.LoadScene(3);
    }
}
