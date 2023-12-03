using UnityEngine;
using System.Collections;

public class ToggleButtons : MonoBehaviour {
    public GameObject model;
    public GameObject networking;

    //each toggle when clicked, calls the appropriately named function to turn object visibility on or off.
    //Each click is recorded. See MRIToggleSkull as it is different.

    public void toggleSkullOnClick()
    {
        model.GetComponent<DisplayObjVisibility3D>().toggleSkull();
    }

    public void toggleLCortexOnClick()
    {
        model.GetComponent<DisplayObjVisibility3D>().toggleLCortex();
        networking.GetComponent<NetworkService>().RecordMouse("ToggleLCortex", 1);
    }

    public void toggleRCortexOnClick()
    {
        model.GetComponent<DisplayObjVisibility3D>().toggleRCortex();
        networking.GetComponent<NetworkService>().RecordMouse("ToggleRCortex", 1);
    }

    public void toggleWhiteMatterOnClick()
    {
        model.GetComponent<DisplayObjVisibility3D>().toggleWhiteMatter();
        networking.GetComponent<NetworkService>().RecordMouse("ToggleWhiteMatter", 1);
    }

    public void toggleCereOnClick()
    {
        model.GetComponent<DisplayObjVisibility3D>().toggleCere();
        networking.GetComponent<NetworkService>().RecordMouse("ToggleCere", 1);
    }

    public void toggleBasalGangOnClick()
    {
        model.GetComponent<DisplayObjVisibility3D>().toggleBasalGang();
        networking.GetComponent<NetworkService>().RecordMouse("ToggleBG", 1);
    }

    public void toggleVasOnClick()
    {
        model.GetComponent<DisplayObjVisibility3D>().toggleVas();
        networking.GetComponent<NetworkService>().RecordMouse("ToggleVas", 1);
    }

    public void toggleSinusOnClick()
    {
        model.GetComponent<DisplayObjVisibility3D>().toggleSinus();
        networking.GetComponent<NetworkService>().RecordMouse("ToggleSinus", 1);
    }

    public void toggleNerveOnClick()
    {
        model.GetComponent<DisplayObjVisibility3D>().toggleNerve();
        networking.GetComponent<NetworkService>().RecordMouse("ToggleNerves", 1);
    }
}
