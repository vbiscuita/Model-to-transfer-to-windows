using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.UI;
using UnityEngine;

public class MRIToggle2D : MonoBehaviour 
{
   
    public GameObject viewImage1;
    public GameObject viewImage2;
    public GameObject viewMRI1;
    public GameObject viewMRI2;
    public Toggle view1;
    public Toggle view2;
    public GameObject networking;

    public void OnView1Press()
    {
        if (view1.isOn)
        {
            viewImage1.SetActive(true);
            viewImage2.SetActive(false);
            view2.isOn = false;
            viewMRI1.SetActive(true);
            viewMRI2.SetActive(false);

            networking.GetComponent<NetworkService>().RecordMouse(view1.gameObject.name, 1);
        }
        
    }

    public void OnView2Press()
    {
        if (view2.isOn)
        {
            viewImage1.SetActive(false);
            viewImage2.SetActive(true);
            view1.isOn = false;
            viewMRI1.SetActive(false);
            viewMRI2.SetActive(true);

            networking.GetComponent<NetworkService>().RecordMouse(view2.gameObject.name, 1);
        }

    }
}
