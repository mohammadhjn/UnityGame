using UnityEngine;

public class Powerup_SlowMotion : MonoBehaviour
{
    public float duration = 5f;
    private bool isActive = false;

    public void Activate()
    {
        if (isActive) return;
        isActive = true;
        Time.timeScale = 0.5f;
        Time.fixedDeltaTime = 0.02f * Time.timeScale;
        Invoke("ResetTime", duration);
    }

    private void ResetTime()
    {
        Time.timeScale = 1f;
        Time.fixedDeltaTime = 0.02f;
        isActive = false;
    }
}
