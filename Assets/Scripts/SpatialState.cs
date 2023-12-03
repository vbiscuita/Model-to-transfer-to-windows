using UnityEngine;
using System.Collections;

public class SpatialState : MonoBehaviour
{
    //called to set the start position and orientation of the brain model and then at the end of the brain model movement
    //it is called again for the final position and orientation of the movement.
    public double x;
    public double y;
    public double zoom;

    public double alpha;
    public double beta;
    public double gamma;

    public string start = System.DateTime.Now.ToString("o");
    public string end = "";

    public string objectId;

    public void SetObjectID(string name)
    {
        objectId = name;
    }

    //get the position and orientation of the brain model
    public void getPostion(GameObject brainmodel)
    {
        x = brainmodel.gameObject.transform.position.x;
        y = brainmodel.gameObject.transform.position.y;
        zoom = brainmodel.gameObject.transform.position.z;

        alpha = brainmodel.gameObject.transform.eulerAngles.x;
        beta = brainmodel.gameObject.transform.eulerAngles.y;
        gamma = brainmodel.gameObject.transform.eulerAngles.z;
    }

    //set the end time of the move
    public void RunFinalized()
    {
        end = System.DateTime.Now.ToString("o");
    }
}
