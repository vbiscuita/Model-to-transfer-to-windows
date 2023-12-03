using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sagittal : MonoBehaviour {

    public GameObject MRI;

    public void OnClick()
    {
        MRI.GetComponent<MRIToggle>().sagittalToggle();
    }
}
