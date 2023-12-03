using UnityEngine;
using System.Collections;

public class CerebellumShow : MonoBehaviour {
    public GameObject text;
    public GameObject displayObj;
	public bool is3D;
    public GameObject parent;
    public GameObject networking;

    public void cerebellumClick()
    {
        parent.GetComponent<OnButtonClick>().cereOnClick();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
    }

    public void cereCortexShowObj()
    {
        parent.GetComponent<OnButtonClick>().cereCortexOnClick();
        text.GetComponent<TextVisibility>().cereCortexShowText();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
			displayObj.GetComponent<DisplayObjVisibility3D>().cereCortexShowObj();
		else
			displayObj.GetComponent<DisplayObjVisibility2D>().cereCortexShowObj();
    }

    public void pedunclesShowObj()
    {
        parent.GetComponent<OnButtonClick>().pedunclesOnClick();
        text.GetComponent<TextVisibility>().pedunclesShowText();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
			displayObj.GetComponent<DisplayObjVisibility3D>().pedunclesShowObj();
		else
			displayObj.GetComponent<DisplayObjVisibility2D>().pedunclesShowObj();
    }

    public void vermisShowObj()
    {
        parent.GetComponent<OnButtonClick>().vermisOnClick();
        text.GetComponent<TextVisibility>().vermisShowText();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
			displayObj.GetComponent<DisplayObjVisibility3D>().vermisShowObj();
		else
			displayObj.GetComponent<DisplayObjVisibility2D>().vermisShowObj();
    }

    public void cereWhiteMatterShowObj()
    {
        parent.GetComponent<OnButtonClick>().cereWhiteMatterOnClick();
        text.GetComponent<TextVisibility>().cereWhiteMatterShowText();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
			displayObj.GetComponent<DisplayObjVisibility3D>().cereWhiteMatterShowObj();
		else
			displayObj.GetComponent<DisplayObjVisibility2D>().cereWhiteMatterShowObj();
    }
}
