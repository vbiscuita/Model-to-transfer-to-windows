using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ResetView : MonoBehaviour
{
    public GameObject obj;
    public GameObject networking;

    public void resetViewButt()
    {
        obj.GetComponent<ObjectMovement>().ResetModelPositionRot();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
    }

}