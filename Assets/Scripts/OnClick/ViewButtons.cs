using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ViewButtons : MonoBehaviour {
    public GameObject obj;
    public Dropdown RotPanButt;

    public void RotPanSwitch()
    {
        if (RotPanButt.value == 0)
            obj.GetComponent<ObjectMovement>().rotateObj();
        if (RotPanButt.value == 1)
            obj.GetComponent<ObjectMovement>().panObj();
    }
}
