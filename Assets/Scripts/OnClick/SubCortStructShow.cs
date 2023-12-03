using UnityEngine;
using System.Collections;

public class SubCortStructShow : MonoBehaviour{
    public GameObject text;
    public GameObject displayObj;
	public bool is3D;
    public GameObject parent;
    public GameObject networking;

    public void subCortClick()
    {
        parent.GetComponent<OnButtonClick>().subCortOnClick();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
    }

    public void whiteMatterShowObj()
    {
        parent.GetComponent<OnButtonClick>().whiteMatterOnClick();
        text.GetComponent<TextVisibility>().whiteMatterShowText();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
			displayObj.GetComponent<DisplayObjVisibility3D>().whiteMatterShowObj();
		else
			displayObj.GetComponent<DisplayObjVisibility2D>().whiteMatterShowObj();
    }

    public void corpCallShowObj()
    {
        parent.GetComponent<OnButtonClick>().corpCallOnClick();
        text.GetComponent<TextVisibility>().corpCallShowText();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
			displayObj.GetComponent<DisplayObjVisibility3D>().corpCallShowObj();
		else
			displayObj.GetComponent<DisplayObjVisibility2D>().corpCallShowObj();
    }

    public void intCapShowObj()
    {
        parent.GetComponent<OnButtonClick>().intCapOnClick();
        text.GetComponent<TextVisibility>().intCapShowText();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
			displayObj.GetComponent<DisplayObjVisibility3D>().intCapShowObj();
		else
			displayObj.GetComponent<DisplayObjVisibility2D>().intCapShowObj();
    }

    public void fornixShowObj()
    {
        parent.GetComponent<OnButtonClick>().fornixOnClick();
        text.GetComponent<TextVisibility>().fornixShowText();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
			displayObj.GetComponent<DisplayObjVisibility3D>().fornixShowObj();
		else
			displayObj.GetComponent<DisplayObjVisibility2D>().fornixShowObj();
    }

    public void caudateNucShowObj()
    {
        parent.GetComponent<OnButtonClick>().caudateNucOnClick();
        text.GetComponent<TextVisibility>().caudateNucShowText();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
			displayObj.GetComponent<DisplayObjVisibility3D>().caudateNucShowObj();
		else
			displayObj.GetComponent<DisplayObjVisibility2D>().caudateNucShowObj();
    }

    public void gloPallShowObj()
    {
        parent.GetComponent<OnButtonClick>().gloPallOnClick();
        text.GetComponent<TextVisibility>().gloPallShowText();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
			displayObj.GetComponent<DisplayObjVisibility3D>().gloPallShowObj();
		else
			displayObj.GetComponent<DisplayObjVisibility2D>().gloPallShowObj();
    }

    public void putamenShowObj()
    {
        parent.GetComponent<OnButtonClick>().putamenOnClick();
        text.GetComponent<TextVisibility>().putamenShowText();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
			displayObj.GetComponent<DisplayObjVisibility3D>().putamenShowObj();
		else
			displayObj.GetComponent<DisplayObjVisibility2D>().putamenShowObj();
    }

    public void thalamusShowObj()
    {
        parent.GetComponent<OnButtonClick>().thalamusOnClick();
        text.GetComponent<TextVisibility>().thalamusShowText();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
			displayObj.GetComponent<DisplayObjVisibility3D>().thalamusShowObj();
		else
			displayObj.GetComponent<DisplayObjVisibility2D>().thalamusShowObj();
    }

    public void hypothalamusShowObj()
    {
        parent.GetComponent<OnButtonClick>().hypoOnClick();
        text.GetComponent<TextVisibility>().hypothalamusShowText();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
			displayObj.GetComponent<DisplayObjVisibility3D>().hypothalamusShowObj();
		else
			displayObj.GetComponent<DisplayObjVisibility2D>().hypothalamusShowObj();
    }

    public void hippocampusShowObj()
    {
        parent.GetComponent<OnButtonClick>().hippoOnClick();
        text.GetComponent<TextVisibility>().hippocampusShowText();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
			displayObj.GetComponent<DisplayObjVisibility3D>().hippocampusShowObj();
		else
			displayObj.GetComponent<DisplayObjVisibility2D>().hippocampusShowObj();
    }
}
