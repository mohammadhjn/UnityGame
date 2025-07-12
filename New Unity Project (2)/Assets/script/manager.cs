using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using UnityEngine.UI;


public class manager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    [SerializeField]
    private Text myText;
    // Update is called once per frame
    void Update()
    {
        myText.text = deletingperacci.score.ToString();
    }
}
