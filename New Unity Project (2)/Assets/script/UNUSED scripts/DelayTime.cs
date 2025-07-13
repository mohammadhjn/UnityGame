using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayTime : MonoBehaviour
{
    private SpriteRenderer sr;
    public Color color1;
    public Color color2;



    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start Function Called...");
        sr = GetComponent<SpriteRenderer>();
        StartCoroutine(ChangeColor2());
    }

    
        
    

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator ChangeColor2()
    {
        while (true)
        {
            if (sr.color == color1)
            {
                sr.color = color2;
                Debug.Log("Change color to " + color2);
            }
            else
            {
                sr.color = color1;
                Debug.Log("Change to color to "+ color1);
            }
            yield return new WaitForSeconds(3);
        }
    }
}
