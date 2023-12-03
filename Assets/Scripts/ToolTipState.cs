using UnityEngine;

public class ToolTipState : MonoBehaviour {

    public string objectId;

    public string start;
    public string end;

    public float start_x;
    public float start_y;

    public float end_x;
    public float end_y;

    public void SetStart(string structName)
    {
        objectId = structName;
        start = System.DateTime.Now.ToString("o");
        start_x = Input.mousePosition.x;
        start_y = Input.mousePosition.y;
    }
	
    public void End()
    {
        end = System.DateTime.Now.ToString("o");
        end_x = Input.mousePosition.x;
        end_y = Input.mousePosition.y;
    }

}
