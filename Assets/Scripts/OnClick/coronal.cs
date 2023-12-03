using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coronal : MonoBehaviour {

    public GameObject MRI;

    public void OnClick()
    {
        MRI.GetComponent<MRIToggle>().coronalToggle();
    }
}
