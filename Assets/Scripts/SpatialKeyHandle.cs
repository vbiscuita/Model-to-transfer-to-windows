using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpatialKeyHandle : MonoBehaviour
{

    private SpatialState prevState;
    public GameObject networking;
    public GameObject brainmodel;
    private bool scrollWheel = false;
    public string name;

    // Use this for initialization
    void Start()
    {
        // Send the current information as the "state of the world"
        prevState = NewSpatialState();
        SendSpatialState(prevState);
    }

    private List<KeyCode> sensitiveKeys = new List<KeyCode>(new[] {
        //all keys that are used in movement
        KeyCode.UpArrow, KeyCode.DownArrow, KeyCode.LeftArrow, KeyCode.RightArrow,
        KeyCode.A, KeyCode.S, KeyCode.D, KeyCode.F, KeyCode.Z, KeyCode.X
    });

    // Update is called once per frame
    void Update()
    {
        // key was pressed or released
        if (sensitiveKeys.Exists(key => Input.GetKeyDown(key) || Input.GetKeyUp(key)))
        {
            NewSpatialState();
        }

        //if scroll wheel is being moved
        if (Input.GetAxis("Mouse ScrollWheel") != 0 && scrollWheel == false)
        {
            scrollWheel = true;
            NewSpatialState();
        }

        //if scroll wheel movement has finished
        if (Input.GetAxis("Mouse ScrollWheel") == 0 && scrollWheel == true)
        {
            NewSpatialState();
            scrollWheel = false;
        }
    }

    public SpatialState NewSpatialState()
    {
        //if two keys are pressed at almost the same time, the first creates a spatial set, if the spatial
        //state still exists then that spatial state is sent when the second button is pressed.
        if (prevState)
        {
            SendSpatialState(prevState);
        }

        SpatialState spatial = this.gameObject.AddComponent<SpatialState>();
        spatial.SetObjectID(name);
        spatial.getPostion(brainmodel);
        return (prevState = spatial);
    }

    //Get the final position/orientation of the model and then send the state to the networking script
    public void SendSpatialState(SpatialState spatial)
    {
        spatial.getPostion(brainmodel);
        spatial.RunFinalized();
        networking.GetComponent<NetworkService>().RecordSpatial(spatial);
        prevState = null;
    }

    //scroll wheel is used for zoom
    public void zoom()
    {
        NewSpatialState();
    }
}