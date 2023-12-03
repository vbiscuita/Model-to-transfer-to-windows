using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MRIAllToggles : MonoBehaviour {

    public GameObject parent;

    public void OnView1()
    {
        parent.GetComponent<MRIToggle2D>().OnView1Press();
    }

    public void OnView2()
    {
        parent.GetComponent<MRIToggle2D>().OnView2Press();
    }

}
