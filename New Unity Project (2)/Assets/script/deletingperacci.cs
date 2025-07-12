using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deletingperacci : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    public AudioClip zaminaudio;
    public AudioClip satleaudio;
    public static int score;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "satle")
        {
            soundmanager.Instance.PlaySound(satleaudio);
            score++;
            Destroy(gameObject);
        }
        else if (other.gameObject.tag == "zamin")
        {
            soundmanager.Instance.PlaySound(zaminaudio);
            score--;
            Destroy(gameObject);
        }
    }

    void Update()
    {
        
    }
}

