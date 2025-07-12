using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deleting : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    [SerializeField]
    private KeyCode keytodestroy;
    void Update()
    {
        if (Input.GetKeyDown(keytodestroy))
        {
            Destroy (gameObject);
        }
    }
}
