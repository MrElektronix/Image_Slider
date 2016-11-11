using UnityEngine;
using UnityEngine.UI;

public class ImageSlider : MonoBehaviour
{
   TimerForSlider timerforslider;

    public Sprite[] Images;
    //public Sprite _currentImage;
    public Image displayImage;
    public Button NextButton;
    public Button PreviousButton;
    public int i;


    // Use this for initialization
    void Start()
    {
        timerforslider = TimerForSlider.instance;
    
    }
     
    void Update()
    {
        displayImage.sprite = Images[i];
        Dia();
    }

    public void Previous()
    {
   
        if (i > 0)
        {
            i--;
            Debug.Log(displayImage);
        }
        else
        {
            i = Images.Length - 1;
        }
    }

    public void Next()
    {
        if (i < Images.Length - 1)
        {
            i++;
            Debug.Log(displayImage);
        }
        else {
            i = 0;
        }
    }

    public void Dia()
    {
        timerforslider.ImageTime -= 1f * Time.deltaTime;
        if (timerforslider.ImageTime <= 0)
        {
            timerforslider.ImageTime = 5f ;
            Next();
        }
    }

}
