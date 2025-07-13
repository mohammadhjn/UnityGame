using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SplashScreen : MonoBehaviour
{
    public CanvasGroup canvasGroup;
    public float fadeDuration = 1f;
    public float waitTime = 2f;
    public string defaultNextScene = "MainMenu";

    void Start()
    {
        StartCoroutine(FadeAndLoad());
    }

    IEnumerator FadeAndLoad()
    {
        // Fade In
        yield return StartCoroutine(Fade(0f, 1f));
        
        // مکث بعد از نمایش لوگو
        yield return new WaitForSeconds(waitTime);

        // Fade Out
        yield return StartCoroutine(Fade(1f, 0f));

        // رفتن به صحنه بعد
        string nextScene = PlayerPrefs.GetString("NextScene", defaultNextScene);
        SceneManager.LoadScene(nextScene);
    }

    IEnumerator Fade(float startAlpha, float endAlpha)
    {
        float time = 0f;
        while (time < fadeDuration)
        {
            time += Time.deltaTime;
            float alpha = Mathf.Lerp(startAlpha, endAlpha, time / fadeDuration);
            canvasGroup.alpha = alpha;
            yield return null;
        }

        canvasGroup.alpha = endAlpha;
    }
}
