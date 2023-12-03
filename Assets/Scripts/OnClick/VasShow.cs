using UnityEngine;
using System.Collections;

public class VasShow : MonoBehaviour {
    public GameObject text;
    public GameObject displayObj;
	public bool is3D;
    public GameObject parent;
    public GameObject networking;

    public void vasClick()
    {
        parent.GetComponent<OnButtonClick>().vasOnClick();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
    }

    public void vasCommCarClick()
    {
        parent.GetComponent<OnButtonClick>().vasCommCarOnClick();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (!is3D)
            displayObj.GetComponent<DisplayObjVisibility2D>().CommCarotidArtShowObj();
    }

    public void ASArtShowObj()
    {
        parent.GetComponent<OnButtonClick>().ASAOnClick();
        text.GetComponent<TextVisibility>().ASArtShowText();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
			displayObj.GetComponent<DisplayObjVisibility3D>().ASArtShowObj();
		else
			displayObj.GetComponent<DisplayObjVisibility2D>().ASArtShowObj();
    }

    public void VertArtShowObj()
    {
        text.GetComponent<TextVisibility>().VertArtShowText();
        parent.GetComponent<OnButtonClick>().vasVertOnClick();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
			displayObj.GetComponent<DisplayObjVisibility3D>().VertArtShowObj();
		else
			displayObj.GetComponent<DisplayObjVisibility2D>().VertArtShowObj();
    }

    public void PostInfCereArtShowObj()
    {
        parent.GetComponent<OnButtonClick>().PostInfCereArtOnClick();
        text.GetComponent<TextVisibility>().PostInfCereArtShowText();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
			displayObj.GetComponent<DisplayObjVisibility3D>().PostInfCereArtShowObj();
		else
			displayObj.GetComponent<DisplayObjVisibility2D>().PostInfCereArtShowObj();
    }

    public void BasilarArtShowObj()
    {
        text.GetComponent<TextVisibility>().BasilarArtShowText();
        parent.GetComponent<OnButtonClick>().vasBasilarOnClick();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
			displayObj.GetComponent<DisplayObjVisibility3D>().BasilarArtShowObj();
		else
			displayObj.GetComponent<DisplayObjVisibility2D>().BasilarArtShowObj();
    }

    public void AntInfCereArtShowObj()
    {
        text.GetComponent<TextVisibility>().AntInfCereArtShowText();
        parent.GetComponent<OnButtonClick>().vasBasilarAntInfCereOnClick();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
        {
            displayObj.GetComponent<DisplayObjVisibility3D>().AntInfCereArtShowObj();
            GameObject brain = GameObject.Find("BrainModel");
            brain.gameObject.GetComponent<ObjectMovement>().x25Zoom();
        }
        else
            displayObj.GetComponent<DisplayObjVisibility2D>().AntInfCereArtShowObj();
    }

    public void PontineArtShowObj()
    {
        parent.GetComponent<OnButtonClick>().PontineOnClick();
        text.GetComponent<TextVisibility>().PontineArtShowText();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
        {
            displayObj.GetComponent<DisplayObjVisibility3D>().PontineArtShowObj();
            GameObject brain = GameObject.Find("BrainModel");
            brain.gameObject.GetComponent<ObjectMovement>().x25Zoom();
        }
        else
            displayObj.GetComponent<DisplayObjVisibility2D>().PontineArtShowObj();
    }

    public void SupCereArtShowObj()
    {
        parent.GetComponent<OnButtonClick>().SupCereArtOnClick();
        text.GetComponent<TextVisibility>().SupCereArtShowText();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
        {
            displayObj.GetComponent<DisplayObjVisibility3D>().SupCereArtShowObj();
            GameObject brain = GameObject.Find("BrainModel");
            brain.gameObject.GetComponent<ObjectMovement>().x25Zoom();
        }
        else
            displayObj.GetComponent<DisplayObjVisibility2D>().SupCereArtShowObj();
    }

    public void FacialArtShowObj()
    {
        parent.GetComponent<OnButtonClick>().FacialArtOnClick();
        text.GetComponent<TextVisibility>().FacialArtShowText();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
			displayObj.GetComponent<DisplayObjVisibility3D>().FacialArtShowObj();
		else
			displayObj.GetComponent<DisplayObjVisibility2D>().FacialArtShowObj();
    }

    public void IntCarotidArtShowObj()
    {
        text.GetComponent<TextVisibility>().IntCarotidArtShowText();
        parent.GetComponent<OnButtonClick>().vasIntCarOnClick();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
			displayObj.GetComponent<DisplayObjVisibility3D>().IntCarotidArtShowObj();
		else
			displayObj.GetComponent<DisplayObjVisibility2D>().IntCarotidArtShowObj();
    }

    public void LabArtShowObj()
    {
        parent.GetComponent<OnButtonClick>().LabArtOnClick();
        text.GetComponent<TextVisibility>().LabArtShowText();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
        {
            displayObj.GetComponent<DisplayObjVisibility3D>().LabArtShowObj();
            GameObject brain = GameObject.Find("BrainModel");
            brain.gameObject.GetComponent<ObjectMovement>().x25Zoom();
        }
        else
            displayObj.GetComponent<DisplayObjVisibility2D>().LabArtShowObj();
    }

    public void MaxArtShowObj()
    {
        text.GetComponent<TextVisibility>().MaxArtShowText();
        parent.GetComponent<OnButtonClick>().vasExtCarMaxArtOnClick();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
			displayObj.GetComponent<DisplayObjVisibility3D>().MaxArtShowObj();
		else
			displayObj.GetComponent<DisplayObjVisibility2D>().MaxArtShowObj();
    }

    public void MidCerebralArtShowObj()
    {
        parent.GetComponent<OnButtonClick>().MidCerebralArtOnClick();
        text.GetComponent<TextVisibility>().MidCerebralArtShowText();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
        {
            displayObj.GetComponent<DisplayObjVisibility3D>().MidCerebralArtShowObj();
            GameObject brain = GameObject.Find("BrainModel");
            brain.gameObject.GetComponent<ObjectMovement>().x15Zoom();
        }
        else
            displayObj.GetComponent<DisplayObjVisibility2D>().MidCerebralArtShowObj();
    }

    public void OccipitalArtShowObj()
    {
        parent.GetComponent<OnButtonClick>().OccipitalArtOnClick();
        text.GetComponent<TextVisibility>().OccipitalArtShowText();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
			displayObj.GetComponent<DisplayObjVisibility3D>().OccipitalArtShowObj();
		else
			displayObj.GetComponent<DisplayObjVisibility2D>().OccipitalArtShowObj();
    }

    public void OpthalmicArtShowObj()
    {
        parent.GetComponent<OnButtonClick>().OpthalmicArtOnClick();
        text.GetComponent<TextVisibility>().OpthalmicArtShowText();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
        {
            displayObj.GetComponent<DisplayObjVisibility3D>().OpthalmicArtShowObj();
            GameObject brain = GameObject.Find("BrainModel");
            brain.gameObject.GetComponent<ObjectMovement>().x15Zoom();
        }
        else
            displayObj.GetComponent<DisplayObjVisibility2D>().OpthalmicArtShowObj();
    }

    public void PostCerebralArtShowObj()
    {
        parent.GetComponent<OnButtonClick>().PostCerebralOnClick();
        text.GetComponent<TextVisibility>().PostCerebralArtShowText();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
        {
            displayObj.GetComponent<DisplayObjVisibility3D>().PostCerebralArtShowObj();
            GameObject brain = GameObject.Find("BrainModel");
            brain.gameObject.GetComponent<ObjectMovement>().x15Zoom();
        }
        else
            displayObj.GetComponent<DisplayObjVisibility2D>().PostCerebralArtShowObj();
    }

    public void AntCerebralArtShowObj()
    {
        text.GetComponent<TextVisibility>().AntCerebralArtShowText();
        parent.GetComponent<OnButtonClick>().vasIntCarAntCerebralOnClick();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
        {
            displayObj.GetComponent<DisplayObjVisibility3D>().AntCerebralArtShowObj();
            GameObject brain = GameObject.Find("BrainModel");
            brain.gameObject.GetComponent<ObjectMovement>().x15Zoom();
        }
        else
            displayObj.GetComponent<DisplayObjVisibility2D>().AntCerebralArtShowObj();
    }

    public void AscPharArtShowObj()
    {
        parent.GetComponent<OnButtonClick>().AscPharArtOnClick();
        text.GetComponent<TextVisibility>().AscPharArtShowText();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
			displayObj.GetComponent<DisplayObjVisibility3D>().AscPharArtShowObj();
		else
			displayObj.GetComponent<DisplayObjVisibility2D>().AscPharArtShowObj();
    }

    public void PostAuricularArtShowObj()
    {
        parent.GetComponent<OnButtonClick>().PostAuricularArtOnClick();
        text.GetComponent<TextVisibility>().PostAuricularArtShowText();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
			displayObj.GetComponent<DisplayObjVisibility3D>().PostAuricularArtShowObj();
		else
			displayObj.GetComponent<DisplayObjVisibility2D>().PostAuricularArtShowObj();
    }

    public void PostCommArtArtShowObj()
    {
        parent.GetComponent<OnButtonClick>().PostCommArtOnClick();
        text.GetComponent<TextVisibility>().PostCommArtArtShowText();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
        {
            displayObj.GetComponent<DisplayObjVisibility3D>().PostCommArtArtShowObj();
            GameObject brain = GameObject.Find("BrainModel");
            brain.gameObject.GetComponent<ObjectMovement>().x15Zoom();
        }
        else
            displayObj.GetComponent<DisplayObjVisibility2D>().PostCommArtArtShowObj();
    }

    public void SupTempArtShowObj()
    {
        parent.GetComponent<OnButtonClick>().SupTempArtOnClick();
        text.GetComponent<TextVisibility>().SupTempArtShowText();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
			displayObj.GetComponent<DisplayObjVisibility3D>().SupTempArtShowObj();
		else
			displayObj.GetComponent<DisplayObjVisibility2D>().SupTempArtShowObj();
    }

    public void ExtCarotidArtShowObj()
    {
        text.GetComponent<TextVisibility>().ExtCarotidArtShowText();
        parent.GetComponent<OnButtonClick>().vasExtCarOnClick();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
			displayObj.GetComponent<DisplayObjVisibility3D>().ExtCarotidArtShowObj();
		else
			displayObj.GetComponent<DisplayObjVisibility2D>().ExtCarotidArtShowObj();
    }

    public void SupThyroidArtShowObj()
    {
        parent.GetComponent<OnButtonClick>().SupThyroidArtOnClick();
        text.GetComponent<TextVisibility>().SupThyroidArtShowText();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
			displayObj.GetComponent<DisplayObjVisibility3D>().SupThyroidArtShowObj();
		else
			displayObj.GetComponent<DisplayObjVisibility2D>().SupThyroidArtShowObj();
    }

    public void LingualArtShowObj()
    {
        parent.GetComponent<OnButtonClick>().LingualArtOnClick();
        text.GetComponent<TextVisibility>().LingualArtShowText();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
			displayObj.GetComponent<DisplayObjVisibility3D>().LingualArtShowObj();
		else
			displayObj.GetComponent<DisplayObjVisibility2D>().LingualArtShowObj();
    }

    public void AntCommArtShowObj()
    {
        parent.GetComponent<OnButtonClick>().AntCommArtOnClick();
        text.GetComponent<TextVisibility>().AntCommArtShowText();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
        {
            displayObj.GetComponent<DisplayObjVisibility3D>().AntCommArtShowObj();
            GameObject brain = GameObject.Find("BrainModel");
            brain.gameObject.GetComponent<ObjectMovement>().x30Zoom();
        }
        else
            displayObj.GetComponent<DisplayObjVisibility2D>().AntCommArtShowObj();
    }

    public void IntJugularShowObj()
    {
        parent.GetComponent<OnButtonClick>().intJugOnClick();
        text.GetComponent<TextVisibility>().IntJugularShowText();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
			displayObj.GetComponent<DisplayObjVisibility3D>().IntJugularShowObj();
		else
			displayObj.GetComponent<DisplayObjVisibility2D>().IntJugularShowObj();
    }
}
