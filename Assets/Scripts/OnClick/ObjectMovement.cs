using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ObjectMovement : MonoBehaviour
{
    bool pan = false;
    bool rotate = true;
    bool flipX = true;
    bool flipY = false;
    public bool is3D;

    float rotationSpeed = 100.0f;
    float translationSpeed = 500.0f;

    public GameObject obj;
    Vector3 modelPosition;
    Quaternion modelRotation = new Quaternion();

    // Use this for initialization
    void Start()
    {  
        //sets the inital position of the 2D and 3D model
        modelPosition = new Vector3(obj.transform.position.x, obj.transform.position.y, obj.transform.position.z);
        if(is3D)
            modelRotation = obj.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (is3D)
        {
            //3D has rotate and pan movement that are changed by which option is selected on screen
            if (rotate)
            {
                var xdir = Input.GetAxis("Horizontal") * (flipX ? -1 : 1);
                obj.transform.Rotate(0, xdir * rotationSpeed * Time.deltaTime, 0, Space.World);
                var ydir = Input.GetAxis("Vertical") * (flipY ? -1 : 1);
                obj.transform.Rotate(ydir * rotationSpeed * Time.deltaTime, 0, 0, Space.World);
            }
            if (pan)
            {
                var xdir = Input.GetAxis("Horizontal") * (flipY ? -1 : 1);
                if (obj.transform.position.x > -190 && obj.transform.position.x < 325)
                    transform.Translate(xdir * translationSpeed * Time.deltaTime, 0, 0, Space.World);
                var ydir = Input.GetAxis("Vertical") * (flipY ? -1 : 1);
                if (obj.transform.position.y < 50 && obj.transform.position.y > -100)
                    transform.Translate(0, ydir * translationSpeed * Time.deltaTime, 0, Space.World);

                //prevents the user from moving the model offscreen
                if (obj.transform.position.x < -190)
                    obj.transform.position = new Vector3(-189.9f, obj.transform.position.y, obj.transform.position.z);
                if (obj.transform.position.x > 300)
                    obj.transform.position = new Vector3(299.9f, obj.transform.position.y, obj.transform.position.z);
                if (obj.transform.position.y < -100)
                    obj.transform.position = new Vector3(obj.transform.position.x, -99.9f, obj.transform.position.z);
                if (obj.transform.position.y > 50)
                    obj.transform.position = new Vector3(obj.transform.position.x, 49.9f, obj.transform.position.z);

            }
            //model zoom
            if (Input.GetAxis("Mouse ScrollWheel") > 0 || Input.GetKeyDown("z"))
            {
                if (obj.transform.position.z > 0)
                    obj.transform.Translate(0, 0, -1 * translationSpeed * Time.deltaTime, Space.World);
            }
            if (Input.GetAxis("Mouse ScrollWheel") < 0 || Input.GetKeyDown("x"))
            {
                if (obj.transform.position.z > 0)
                    obj.transform.Translate(0, 0, translationSpeed * Time.deltaTime, Space.World);
            }
            //prevents user from moving model past camera or too tiny
            if (obj.transform.position.z < 0)
                obj.transform.position = new Vector3(obj.transform.position.x, obj.transform.position.y, 0.1f);
            if (obj.transform.position.z > 500)
                obj.transform.position = new Vector3(obj.transform.position.x, obj.transform.position.y, 499.9f);
        }
        else
        {
            //2D model movement
            var xdir = Input.GetAxis("Horizontal") * (flipY ? -1 : 1);
            if (obj.transform.position.x > 225 && obj.transform.position.x < 1000)
                transform.Translate(xdir * translationSpeed * Time.deltaTime, 0, 0, Space.World);
            var ydir = Input.GetAxis("Vertical") * (flipY ? -1 : 1);
            if (obj.transform.position.y < 620 && obj.transform.position.y > -50)
                transform.Translate(0, ydir * translationSpeed * Time.deltaTime, 0, Space.World);

            if (obj.transform.position.x < 225)
                obj.transform.position = new Vector3(225.1f, obj.transform.position.y, obj.transform.position.z);
            if (obj.transform.position.x > 1000)
                obj.transform.position = new Vector3(999.9f, obj.transform.position.y, obj.transform.position.z);
            if (obj.transform.position.y < -50)
                obj.transform.position = new Vector3(obj.transform.position.x, -49.9f, obj.transform.position.z);
            if (obj.transform.position.y > 620)
                obj.transform.position = new Vector3(obj.transform.position.x, 619.9f, obj.transform.position.z);
        }

    }

    //reset model position and orientation using reset button
    public void ResetModelPositionRot()
    {
        obj.transform.position = modelPosition;
        if(is3D)
            obj.transform.rotation = modelRotation;
    }

    public void panObj()
    {
        rotate = false;
        pan = true;
    }

    public void rotateObj()
    {
        rotate = true;
        pan = false;
    }

    //Certain sturctures require a specific zoom. Functions called when specific structure button is clicked
    public void x15Zoom()
    {
        obj.transform.position = new Vector3(0, (float)-1.5939598, (float)153.8);
        obj.transform.rotation = modelRotation;
        GameObject canvas = GameObject.Find("Canvas");
        canvas.gameObject.GetComponent<SpatialKeyHandle>().zoom();
    }

    public void x25Zoom()
    {
        obj.transform.position = new Vector3(0, (float)-27.5, (float)109.4);
        obj.transform.rotation = modelRotation;
        GameObject canvas = GameObject.Find("Canvas");
        canvas.gameObject.GetComponent<SpatialKeyHandle>().zoom();
    }

    public void x30Zoom()
    {
        obj.transform.position = new Vector3((float)13, (float)-58.6, (float)41.4);
        obj.transform.rotation = modelRotation;
        GameObject canvas = GameObject.Find("Canvas");
        canvas.gameObject.GetComponent<SpatialKeyHandle>().zoom();
    }
}
