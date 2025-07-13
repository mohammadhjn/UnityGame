using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class DoubleScorePowerup : MonoBehaviour
{
    public int cost = 4; 
    public float cooldown = 10f;
    public float duration = 3f;

    private float lastUseTime = -100f;

    public Button powerupButton;

    public Color readyColor = new Color(0f, 0.81f, 1f);      // آبی (آماده)
    public Color activeColor = new Color(0f, 1f, 0f);         // سبز (فعال)
    public Color cooldownColor = new Color(0.4f, 0.4f, 0.4f); // خاکستری (کول‌داون)

    void Start()
    {
        if (powerupButton != null)
            powerupButton.onClick.AddListener(TryActivate);

        UpdateButtonColor();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            TryActivate();
        }

        UpdateButtonColor();
    }

    void TryActivate()
    {
        if (Time.time - lastUseTime < cooldown)
        {
            Debug.Log("Powerup is on cooldown.");
            return;
        }

        if (deletingperacci.score < cost)
        {
            Debug.Log("Not enough score to activate powerup.");
            return;
        }

        deletingperacci.score -= cost;
        lastUseTime = Time.time;
        StartCoroutine(ActivateDoubleScore());
    }

    IEnumerator ActivateDoubleScore()
    {
        deletingperacci.isDoubleScoreActive = true;
        Debug.Log("Double Score Activated!");

        yield return new WaitForSeconds(duration);

        deletingperacci.isDoubleScoreActive = false;
        Debug.Log("Double Score Ended.");
    }

    void UpdateButtonColor()
    {
        if (powerupButton == null)
            return;

        if (Time.time - lastUseTime < duration)
            powerupButton.image.color = activeColor;
        else if (Time.time - lastUseTime < cooldown)
            powerupButton.image.color = cooldownColor;
        else
            powerupButton.image.color = readyColor;
    }
    
}

