using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deletingperacci : MonoBehaviour
{
    public AudioClip zaminaudio;
    public AudioClip satleaudio;
    public static int score;

    public static bool isDoubleScoreActive = false; 

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "satle")
        {
            soundmanager.Instance.PlaySound(satleaudio);

            if (isDoubleScoreActive)
                score += 2;
            else
                score += 1;

            Destroy(gameObject);
        }
        else if (other.gameObject.tag == "zamin")
        {
            soundmanager.Instance.PlaySound(zaminaudio);
            score--;
            Destroy(gameObject);
        }
    }
}
