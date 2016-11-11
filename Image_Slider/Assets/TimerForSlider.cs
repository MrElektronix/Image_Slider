using UnityEngine;

public class TimerForSlider : MonoBehaviour {
    public static TimerForSlider instance;

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("More than one BuildManager in scene!");
            return;
        }
        instance = this;
    }

    public float ImageTime;

	// Update is called once per frame
	void Update () {
        if (ImageTime <= 0)
        {
            ImageTime = 0;
        } else
        {
            Debug.Log(ImageTime);
        }
	}
}
