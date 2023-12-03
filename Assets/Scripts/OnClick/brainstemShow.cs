using UnityEngine;
using System.Collections;

public class brainstemShow : MonoBehaviour {
    public GameObject parent;
    public GameObject networking;

    public void Click()
    {
        parent.GetComponent<OnButtonClick>().brainStemOnClick();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
    }
}
