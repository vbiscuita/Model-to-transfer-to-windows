using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.UI;
using UnityEngine;

public class MRIToggleSkull : MonoBehaviour
{
    public Toggle skull;
    public GameObject networking;

    //Checks to make sure the MRItoggles are off before recording a click.
    public void OnClick()
    {
        GameObject MRI = GameObject.Find("MRIToggles");

        if (MRI.GetComponent<MRIToggle>().axial.isOn == true || MRI.GetComponent<MRIToggle>().coronal.isOn == true ||
            MRI.GetComponent<MRIToggle>().sagittal.isOn == true)
        {
            skull.isOn = false;
        }
        else
        {
            networking.GetComponent<NetworkService>().RecordMouse("ToggleSkull", 1);
        }
    }
}
