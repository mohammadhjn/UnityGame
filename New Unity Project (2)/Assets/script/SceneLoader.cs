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

}
