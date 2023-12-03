using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System.Text;

public class Tooltip : MonoBehaviour//EventTrigger, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler 
{
    public string toolTipText = ""; // set this in the Inspector
    public string prevToolTip = "";
    public GameObject newObject;
    public GameObject networking;
    public Camera myCam;

    private string currentToolTipText = "";
    private GUIStyle guiStyleFore;
    private GUIStyle guiStyleBack;

    GameObject currObj;
    private ToolTipState newToolTip;

    private MeshCollider mc;

    void Start()
    {
        guiStyleFore = new GUIStyle();
        guiStyleFore.normal.textColor = Color.black;
        guiStyleFore.alignment = TextAnchor.UpperCenter;
        guiStyleFore.wordWrap = true;
        guiStyleFore.fontSize = 20;
    }

    void FixedUpdate()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            RaycastHit hit = new RaycastHit();
            Ray ray = myCam.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                currentToolTipText = hit.collider.transform.gameObject.name;
                bool name = currentToolTipText.Contains("Slice");

                if (!name)
                {
                    if (prevToolTip == "" || prevToolTip != currentToolTipText)
                    {
                        if (newToolTip)
                        {
                            sendData(newToolTip);
                            newToolTip = null;
                        }
                        currentToolTipText = hit.collider.transform.gameObject.name;
                        prevToolTip = currentToolTipText;
                        if (!newToolTip)
                        {
                            newToolTip = NewToolTipState();
                        }

                    }
                }
            }
        }
        else {
            currentToolTipText = "";
            prevToolTip = "";
        }
    }

    void OnGUI()
    {
        bool name = currentToolTipText.Contains("Slice");

        if (!name)
        {
            if (currentToolTipText != "")
            {
                var x = Event.current.mousePosition.x;
                var y = Event.current.mousePosition.y;
                GUI.Label(new Rect(x - 150, y + 20, 300, 200), currentToolTipText, guiStyleFore);
            }
        }
    }

    public ToolTipState NewToolTipState()
    {
        ToolTipState tooltip = gameObject.AddComponent<ToolTipState>();
        tooltip.SetStart(currentToolTipText);
        return tooltip;
    }

    public void sendData(ToolTipState tooltip)
    {
        tooltip.End();
        networking.GetComponent<NetworkService>().RecordToolTip(tooltip);
    }




}
