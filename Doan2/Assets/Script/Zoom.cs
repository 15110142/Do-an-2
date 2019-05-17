using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Zoom : MonoBehaviour {

    public Slider slider;

    void Start()
    {
        slider.value = 0.6f;
    }

    // Update is called once per frame
    void Update()
    {
        Camera.main.fieldOfView = slider.value * 100;

    }
}
