using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    public void LoadSceneByName(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void RepeatSceneByName(string sceneName)
    {
        deletingperacci.score = 0;
        SceneManager.LoadScene(sceneName);
    }
    public void OpenGithub()
    {
        Application.OpenURL("https://github.com/amiramiriani"); // لینک گیتهاب خودت رو جایگزین کن
    }
    public void OpenBazaar()
    {
        Application.OpenURL("https://cafebazaar.ir"); // لینک گیتهاب خودت رو جایگزین کن
    }
    
}
