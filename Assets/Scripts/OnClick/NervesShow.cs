using UnityEngine;
using System.Collections;

public class NervesShow : MonoBehaviour {
    public GameObject text;
    public GameObject displayObj;
	public bool is3D;
    public GameObject parent;
    public GameObject networking;

    public void nervesClick()
    {
        parent.GetComponent<OnButtonClick>().nervesOnClick();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
    }

    public void CNIShowObj()
    {
        parent.GetComponent<OnButtonClick>().cnIOnClick(); //changes button colour/menu layout
        text.GetComponent<TextVisibility>().CNIShowText(); //display appropriate 
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
			displayObj.GetComponent<DisplayObjVisibility3D>().CNIShowObj();
		else
			displayObj.GetComponent<DisplayObjVisibility2D>().CNIShowObj();
    }

    public void CNIIShowObj()
    {
        parent.GetComponent<OnButtonClick>().cnIIOnClick();
        text.GetComponent<TextVisibility>().CNIIShowText();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
			displayObj.GetComponent<DisplayObjVisibility3D>().CNIIShowObj();
		else
			displayObj.GetComponent<DisplayObjVisibility2D>().CNIIShowObj();
    }

    public void CNIIIShowObj()
    {
        parent.GetComponent<OnButtonClick>().cnIIIOnClick();
        text.GetComponent<TextVisibility>().CNIIIShowText();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
			displayObj.GetComponent<DisplayObjVisibility3D>().CNIIIShowObj();
		else
			displayObj.GetComponent<DisplayObjVisibility2D>().CNIIIShowObj();
    }

    public void CNIVShowObj()
    {
        parent.GetComponent<OnButtonClick>().cnIVOnClick();
        text.GetComponent<TextVisibility>().CNIVShowText();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
			displayObj.GetComponent<DisplayObjVisibility3D>().CNIVShowObj();
		else
			displayObj.GetComponent<DisplayObjVisibility2D>().CNIVShowObj();
    }

    public void CNVShowObj()
    {
        parent.GetComponent<OnButtonClick>().cnVOnClick();
        text.GetComponent<TextVisibility>().CNVShowText();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
			displayObj.GetComponent<DisplayObjVisibility3D>().CNVShowObj();
		else
			displayObj.GetComponent<DisplayObjVisibility2D>().CNVShowObj();
	}

    public void CNVIShowObj()
    {
        parent.GetComponent<OnButtonClick>().cnVIOnClick();
        text.GetComponent<TextVisibility>().CNVIShowText();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
			displayObj.GetComponent<DisplayObjVisibility3D>().CNVIShowObj();
		else
			displayObj.GetComponent<DisplayObjVisibility2D>().CNVIShowObj();
    }

    public void CNVIIShowObj()
    {
        parent.GetComponent<OnButtonClick>().cnVIIOnClick();
        text.GetComponent<TextVisibility>().CNVIIShowText();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
			displayObj.GetComponent<DisplayObjVisibility3D>().CNVIIShowObj();
		else
			displayObj.GetComponent<DisplayObjVisibility2D>().CNVIIShowObj();
    }

    public void CNVIIIShowObj()
    {
        parent.GetComponent<OnButtonClick>().cnVIIIOnClick();
        text.GetComponent<TextVisibility>().CNVIIIShowText();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
			displayObj.GetComponent<DisplayObjVisibility3D>().CNVIIIShowObj();
		else
			displayObj.GetComponent<DisplayObjVisibility2D>().CNVIIIShowObj();
    }

    public void CNIXShowObj()
    {
        parent.GetComponent<OnButtonClick>().cnIXOnClick();
        text.GetComponent<TextVisibility>().CNIXShowText();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
			displayObj.GetComponent<DisplayObjVisibility3D>().CNIXShowObj();
		else
			displayObj.GetComponent<DisplayObjVisibility2D>().CNIXShowObj();
    }

    public void CNXShowObj()
    {
        parent.GetComponent<OnButtonClick>().cnXOnClick();
        text.GetComponent<TextVisibility>().CNXShowText();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
			displayObj.GetComponent<DisplayObjVisibility3D>().CNXShowObj();
		else
			displayObj.GetComponent<DisplayObjVisibility2D>().CNXShowObj();
    }

    public void CNXIShowObj()
    {
        parent.GetComponent<OnButtonClick>().cnXIOnClick();
        text.GetComponent<TextVisibility>().CNXIShowText();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
			displayObj.GetComponent<DisplayObjVisibility3D>().CNXIShowObj();
		else
			displayObj.GetComponent<DisplayObjVisibility2D>().CNXIShowObj();
    }

    public void CNXIIShowObj()
    {
        parent.GetComponent<OnButtonClick>().cnXIIOnClick();
        text.GetComponent<TextVisibility>().CNXIIShowText();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
			displayObj.GetComponent<DisplayObjVisibility3D>().CNXIIShowObj();
		else
			displayObj.GetComponent<DisplayObjVisibility2D>().CNXIIShowObj();
    }
}
