using UnityEngine;
using System.Collections;

public class VentSysShow : MonoBehaviour {
    public GameObject text;
    public GameObject displayObj;
	public bool is3D;
    public GameObject parent;
    public GameObject networking;

    public void ventClick()
    {
        parent.GetComponent<OnButtonClick>().ventSysOnClick();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
    }

    public void latVentShowObj()
    {
        parent.GetComponent<OnButtonClick>().latVentOnClick();
        text.GetComponent<TextVisibility>().latVentShowText();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
			displayObj.GetComponent<DisplayObjVisibility3D>().latVentShowObj();
		else
			displayObj.GetComponent<DisplayObjVisibility2D>().latVentShowObj();
    }

    public void cerebralAqueShowObj()
    {
        parent.GetComponent<OnButtonClick>().cerebralAqueOnClick();
        text.GetComponent<TextVisibility>().cerebralAqueShowText();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
			displayObj.GetComponent<DisplayObjVisibility3D>().cerebralAqueShowObj();
		else
			displayObj.GetComponent<DisplayObjVisibility2D>().cerebralAqueShowObj();
    }

    public void thirdVentShowObj()
    {
        parent.GetComponent<OnButtonClick>().thirdVentOnClick();
        text.GetComponent<TextVisibility>().thirdVentShowText();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
			displayObj.GetComponent<DisplayObjVisibility3D>().thirdVentShowObj();
		else
			displayObj.GetComponent<DisplayObjVisibility2D>().thirdVentShowObj();
    }

    public void fourthVentShowObj()
    {
        parent.GetComponent<OnButtonClick>().fourthVentOnClick();
        text.GetComponent<TextVisibility>().fourthVentShowText();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
			displayObj.GetComponent<DisplayObjVisibility3D>().fourthVentShowObj();
		else
			displayObj.GetComponent<DisplayObjVisibility2D>().fourthVentShowObj();
    }
}
