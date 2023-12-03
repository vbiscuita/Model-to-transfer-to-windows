using UnityEngine;
using System.Collections;

public class spinalCordShow : MonoBehaviour {
    public GameObject parent;
    public GameObject networking;

    public void Click()
    {
        parent.GetComponent<OnButtonClick>().spinalCordOnClick();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
    }
}
