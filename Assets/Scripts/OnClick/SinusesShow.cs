using UnityEngine;
using System.Collections;

public class SinusesShow : MonoBehaviour {
    public GameObject text;
    public GameObject displayObj;
	public bool is3D;
    public GameObject parent;
    public GameObject networking;

    public void sinusClick()
    {
        parent.GetComponent<OnButtonClick>().sinusesOnClick();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
    }

    public void SupSagSinShowObj()
    {
        parent.GetComponent<OnButtonClick>().supSagSinOnClick();
        text.GetComponent<TextVisibility>().SupSagSinShowText();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
			displayObj.GetComponent<DisplayObjVisibility3D>().SupSagSinShowObj();
		else
			displayObj.GetComponent<DisplayObjVisibility2D>().SupSagSinShowObj();
    }

    public void InfSagSinShowObj()
    {
        parent.GetComponent<OnButtonClick>().infSagSinOnClick();
        text.GetComponent<TextVisibility>().InfSagSinShowText();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
			displayObj.GetComponent<DisplayObjVisibility3D>().InfSagSinShowObj();
		else
			displayObj.GetComponent<DisplayObjVisibility2D>().InfSagSinShowObj();
    }

    public void CavernousSinShowObj()
    {
        parent.GetComponent<OnButtonClick>().cavernousSinOnClick();
        text.GetComponent<TextVisibility>().CavernousSinShowText();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
			displayObj.GetComponent<DisplayObjVisibility3D>().CavernousSinShowObj();
		else
			displayObj.GetComponent<DisplayObjVisibility2D>().CavernousSinShowObj();
    }

    public void SupPetrosalSinShowObj()
    {
        parent.GetComponent<OnButtonClick>().supPetSinOnClick();
        text.GetComponent<TextVisibility>().SupPetrosalSinShowText();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
			displayObj.GetComponent<DisplayObjVisibility3D>().SupPetrosalSinShowObj();
		else
			displayObj.GetComponent<DisplayObjVisibility2D>().SupPetrosalSinShowObj();
    }

    public void SphernoperietalSinShowObj()
    {
        parent.GetComponent<OnButtonClick>().SphernoOnClick();
        text.GetComponent<TextVisibility>().SphernoperietalSinShowText();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
			displayObj.GetComponent<DisplayObjVisibility3D>().SphernoperietalSinShowObj();
		else
			displayObj.GetComponent<DisplayObjVisibility2D>().SphernoperietalSinShowObj();
    }

    public void InfPetrosalSinShowObj()
    {
        parent.GetComponent<OnButtonClick>().infPetSinOnClick();
        text.GetComponent<TextVisibility>().InfPetrosalSinShowText();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
			displayObj.GetComponent<DisplayObjVisibility3D>().InfPetrosalSinShowObj();
		else
			displayObj.GetComponent<DisplayObjVisibility2D>().InfPetrosalSinShowObj();
    }

    public void OccipitalSinShowObj()
    {
        parent.GetComponent<OnButtonClick>().occipitalSinOnClick();
        text.GetComponent<TextVisibility>().OccipitalSinShowText();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
			displayObj.GetComponent<DisplayObjVisibility3D>().OccipitalSinShowObj();
		else
			displayObj.GetComponent<DisplayObjVisibility2D>().OccipitalSinShowObj();
    }

    public void TransSinShowObj()
    {
        parent.GetComponent<OnButtonClick>().transSinOnClick();
        text.GetComponent<TextVisibility>().TransSinShowText();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
			displayObj.GetComponent<DisplayObjVisibility3D>().TransSinShowObj();
		else
			displayObj.GetComponent<DisplayObjVisibility2D>().TransSinShowObj();
    }

    public void SigmoidSinShowObj()
    {
        parent.GetComponent<OnButtonClick>().sigmoidSinOnClick();
        text.GetComponent<TextVisibility>().SigmoidSinShowText();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
			displayObj.GetComponent<DisplayObjVisibility3D>().SigmoidSinShowObj();
		else
			displayObj.GetComponent<DisplayObjVisibility2D>().SigmoidSinShowObj();
    }

    public void StraightSinShowObj()
    {
        parent.GetComponent<OnButtonClick>().straightSinOnClick();
        text.GetComponent<TextVisibility>().StraightSinShowText();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
			displayObj.GetComponent<DisplayObjVisibility3D>().StraightSinShowObj();
		else
			displayObj.GetComponent<DisplayObjVisibility2D>().StraightSinShowObj();
    }
}
