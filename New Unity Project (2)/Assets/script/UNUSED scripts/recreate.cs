using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recreate : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ball;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(ball);
        }
    }
    
}
