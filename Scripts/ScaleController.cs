using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.UI;
using UnityEngine.XR.ARSubsystems;

public class ScaleController : MonoBehaviour
{

    public GameObject battlefield;

    public Slider scaleSlider;

    // Start is called before the first frame update
    void Start()
    {
        scaleSlider.onValueChanged.AddListener(OnSliderValueChanged);
    }


    public void OnSliderValueChanged(float value)
    {
        if (scaleSlider != null)
        {
            battlefield.transform.localScale = Vector3.one / value;

        }
    }


}
