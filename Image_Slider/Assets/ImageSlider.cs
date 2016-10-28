using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ImageSlider : MonoBehaviour
{
    public Sprite[] Images;
    //public Sprite _currentImage;
    public Image displayImage;
    public Button NextButton;
    public Button PreviousButton;
    public int i;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        displayImage.sprite = Images[i];
    }

    public void Previous()
    {
        if (i > 0)
        {
            i--;
            Debug.Log(displayImage);
        }
    }

    public void Next()
    {
        if (i < Images.Length  - 1)
        {
            i++;
            Debug.Log(displayImage);
        }
    }

}
