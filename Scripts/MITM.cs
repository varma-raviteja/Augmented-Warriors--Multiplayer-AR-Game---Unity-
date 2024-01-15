using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;


public class MITM : MonoBehaviour
{
    private ARTrackedImageManager _artmanager;
    public GameObject wiz_panel;
   
    public bool detected;
    

    private void Awake()
    {
        _artmanager=GetComponent<ARTrackedImageManager>();
        detected=false;
        wiz_panel.SetActive(false);

    }

    private void Start()
    {
        _artmanager.trackedImagesChanged+=OnTrackedImageChanged;
        
    }
    private void OnDestroy()
    {
        _artmanager.trackedImagesChanged-=OnTrackedImageChanged;
    }

    private void OnTrackedImageChanged(ARTrackedImagesChangedEventArgs eventArgs)
    {
        foreach(ARTrackedImage trackedImage in eventArgs.updated)
        {
            
            detected=true;
            wiz_panel.SetActive(true);
          
        }
    }
}

