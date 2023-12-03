using UnityEngine;
using System.Collections;

public class Exit : MonoBehaviour {
    public GameObject networking;

    //exit button has been pressed, has networking send all final data
    public void clickExit()
    {
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        networking.GetComponent<NetworkService>().sendEndSession();
    }
}
