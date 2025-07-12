using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class button : MonoBehaviour
{

    [SerializeField]
    private Text myText;
    public Text sliderText;
    public Slider mySlider;
    private int n = 0;

    public void ButtonClick()
    {
        n++;
        myText.text = "This is a function" + n;
        Debug.Log("User clicked on button");
    }
    public void ButtonClickNev()
    {
        n--;
        myText.text = "This is a function" + n;
        Debug.Log("User clicked on button");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    

    
    {
        sliderText.text = "Current Volume:"
            + mySlider.value;

        
    }
}
