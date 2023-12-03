using UnityEngine;
using System.Collections;

public class CortStructShow : MonoBehaviour {
    public GameObject text;
    public GameObject displayObj;
	public bool is3D;
    public GameObject parent;
    public GameObject networking;

    public void cortClick()
    {
        parent.GetComponent<OnButtonClick>().cortStructOnClick();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
    }

    public void cortLobeClick()
    {
        parent.GetComponent<OnButtonClick>().cortLobeOnClick();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
    }

    public void cortGyriClick()
    {
        parent.GetComponent<OnButtonClick>().cortGyriOnClick();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
    }

    public void cortSulciClick()
    {
        parent.GetComponent<OnButtonClick>().cortSulcusOnClick();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
    }

    public void frontalLobeShowObj()
    {
        text.GetComponent<TextVisibility>().frontalLobeShowText();
        parent.GetComponent<OnButtonClick>().frontalLobeOnClick();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
			displayObj.GetComponent<DisplayObjVisibility3D>().frontalLobeShowObj();
		else
			displayObj.GetComponent<DisplayObjVisibility2D>().frontalLobeShowObj();
    }

    public void parietalLobeShowObj()
    {
        text.GetComponent<TextVisibility>().parietalLobeShowText();
        parent.GetComponent<OnButtonClick>().parietalLobeOnClick();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
			displayObj.GetComponent<DisplayObjVisibility3D>().parietalLobeShowObj();
		else
			displayObj.GetComponent<DisplayObjVisibility2D>().parietalLobeShowObj();
    }

    public void temporalLobeShowObj()
    {
        text.GetComponent<TextVisibility>().temporalLobeShowText();
        parent.GetComponent<OnButtonClick>().temporalLobeOnClick();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
			displayObj.GetComponent<DisplayObjVisibility3D>().temporalLobeShowObj();
		else
			displayObj.GetComponent<DisplayObjVisibility2D>().temporalLobeShowObj();
	}

    public void brocasShowObj()
    {
        parent.GetComponent<OnButtonClick>().BrocasOnClick();
        text.GetComponent<TextVisibility>().brocasShowText();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
			displayObj.GetComponent<DisplayObjVisibility3D>().brocasShowObj();
		else
			displayObj.GetComponent<DisplayObjVisibility2D>().brocasShowObj();
    }

    public void frontalEyeFieldShowObj()
    {
        parent.GetComponent<OnButtonClick>().FrontalEyeFieldOnClick();
        text.GetComponent<TextVisibility>().frontalEyeFieldShowText();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
			displayObj.GetComponent<DisplayObjVisibility3D>().frontalEyeFieldShowObj();
		else
			displayObj.GetComponent<DisplayObjVisibility2D>().frontalEyeFieldShowObj();
    }

    public void PreMotorShowObj()
    {
        parent.GetComponent<OnButtonClick>().PreMotorCortexOnClick();
        text.GetComponent<TextVisibility>().preMotorCortexShowText();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
            displayObj.GetComponent<DisplayObjVisibility3D>().preMotorCortexShowObj();
        else
            displayObj.GetComponent<DisplayObjVisibility2D>().preMotorShowObj();
    }

    public void SMAShowObj()
    {
        parent.GetComponent<OnButtonClick>().SMAOnClick();
        text.GetComponent<TextVisibility>().SMAShowText();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
			displayObj.GetComponent<DisplayObjVisibility3D>().SMAShowObj();
		else
			displayObj.GetComponent<DisplayObjVisibility2D>().SMAShowObj();
    }

    public void wernickesShowObj()
    {
        parent.GetComponent<OnButtonClick>().WernickesOnClick();
        text.GetComponent<TextVisibility>().wernickesShowText();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
			displayObj.GetComponent<DisplayObjVisibility3D>().wernickesShowObj();
		else
			displayObj.GetComponent<DisplayObjVisibility2D>().wernickesShowObj();
    }

    public void pariPostCentGyrusShowObj()
    {
        parent.GetComponent<OnButtonClick>().ParietalPostCentGyrusOnClick();
        text.GetComponent<TextVisibility>().postCentGyrusShowText();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
            displayObj.GetComponent<DisplayObjVisibility3D>().postCentGyrusShowObj();
        else
            displayObj.GetComponent<DisplayObjVisibility2D>().postCentGyrusShowObj();
    }

    public void occipitalLobeShowObj()
    {
        parent.GetComponent<OnButtonClick>().OccipitalOnClick();
        text.GetComponent<TextVisibility>().occipitalLobeShowText();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);//("OccipitalLobe");
        if (is3D)
			displayObj.GetComponent<DisplayObjVisibility3D>().occipitalLobeShowObj();
		else
			displayObj.GetComponent<DisplayObjVisibility2D>().occipitalLobeShowObj();
    }

    public void preCentGyrusShowObj()
    {
        parent.GetComponent<OnButtonClick>().PreCentGyrusOnClick();
        text.GetComponent<TextVisibility>().preCentGyrusShowText();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
			displayObj.GetComponent<DisplayObjVisibility3D>().preCentGyrusShowObj();
		else
			displayObj.GetComponent<DisplayObjVisibility2D>().preCentGyrusShowObj();
    }

    public void postCentGyrusShowObj()
    {
        parent.GetComponent<OnButtonClick>().PostCentGyrusOnClick();
        text.GetComponent<TextVisibility>().postCentGyrusShowText();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
			displayObj.GetComponent<DisplayObjVisibility3D>().postCentGyrusShowObj();
		else
			displayObj.GetComponent<DisplayObjVisibility2D>().postCentGyrusShowObj();
    }

    public void cingulateGyrusShowObj()
    {
        parent.GetComponent<OnButtonClick>().CingulateOnClick();
        text.GetComponent<TextVisibility>().cingulateGyrusShowText();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
			displayObj.GetComponent<DisplayObjVisibility3D>().cingulateGyrusShowObj();
		else
			displayObj.GetComponent<DisplayObjVisibility2D>().cingulateGyrusShowObj();
    }

    public void centSulcusShowObj()
    {
        parent.GetComponent<OnButtonClick>().CentSulcusOnClick();
        text.GetComponent<TextVisibility>().centSulcusShowText();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
			displayObj.GetComponent<DisplayObjVisibility3D>().centSulcusShowObj();
		else
			displayObj.GetComponent<DisplayObjVisibility2D>().centSulcusShowObj();
    }

    public void latSulcusShowObj()
    {
        parent.GetComponent<OnButtonClick>().LatSulcusOnClick();
        text.GetComponent<TextVisibility>().latSulcusShowText();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
			displayObj.GetComponent<DisplayObjVisibility3D>().latSulcusShowObj();
		else
			displayObj.GetComponent<DisplayObjVisibility2D>().latSulcusShowObj();
    }

    public void periSulcusShowObj()
    {
        parent.GetComponent<OnButtonClick>().PeriSulcusOnClick();
        text.GetComponent<TextVisibility>().periSulcusShowText();
        networking.GetComponent<NetworkService>().RecordMouse(this.gameObject.name, 1);
        if (is3D)
			displayObj.GetComponent<DisplayObjVisibility3D>().periSulcusShowObj();
		else
			displayObj.GetComponent<DisplayObjVisibility2D>().periSulcusShowObj();
    }
}
