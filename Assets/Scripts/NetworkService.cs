using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using System;
using System.Text;

public class NetworkService : MonoBehaviour
{
    public GameObject canvas;
    public GameObject brain;

//#if UNITY_WEBGL
//    string ServiceURL = "/api/";
//#elif UNITY_STANDALONE
    //string ServiceURL = "http://localhost:3000/";
//#endif

    string uuid;
    string _spatialPath = "spatial/";
    string _mousePath = "mouse/";
    string _sessionPath = "session/";
    string _tooltipPath = "tooltip/";
    string _sessionStartPath;
    string _sessionEndPath;
    float timer;

    public string model;

    int SPATIAL_BUFFER_COUNT = 5;
    int MOUSE_BUFFER_COUNT = 5;
    int TOOLTIP_BUFFER_COUNT = 5;

    int DATA_TIMEOUT_SECONDS = 30;

    List<SpatialState> spatialData = new List<SpatialState>();
    List<MouseState> mouseData = new List<MouseState>();
    List<ToolTipState> tooltipData = new List<ToolTipState>();

    private IEnumerator startSession;
    private IEnumerator sendMouseCo;
    private IEnumerator sendSpatialCo;
    private IEnumerator sendToolTipCo;
    private IEnumerator sendEndSessionCo;

    // Use this for initialization
    void Start()
    {
        DontDestroyOnLoad(this.gameObject); //needed to prevent the deletion of the user name string when this scene is loaded
        timer = Time.time;
        //_sessionStartPath = ServiceURL + _sessionPath + "new";
        //_sessionEndPath = ServiceURL + _sessionPath + "end/";
    }

    public void StartSession(string username)
    {
        //startSession = StartSessionSend(username);
        //StartCoroutine(startSession); //All data sending was done in unthreaded co-routines
    }

    //IEnumerator StartSessionSend(string username)
    //{
    //    StartState start = gameObject.AddComponent<StartState>();
    //    start.start = System.DateTime.Now.ToString("o");
    //    start.userId = username;
    //    start.modelId = model;

    //    string json = JsonUtility.ToJson(start); //converting the start data to the json string

    //    Dictionary<string, string> headers = new Dictionary<string, string>();
    //    headers.Add("Content-Type", "application/json");
    //    //headers.Add("Content-Length", json.Length.ToString());

    //    Debug.Log(json);

    //    //WWW request = new WWW(_sessionStartPath, System.Text.Encoding.UTF8.GetBytes(json), headers);

    //    //yield return request;

    //    ////If the request sends back an error, load the error screen and display the error so users can send it to Lauren
    //    //if (!string.IsNullOrEmpty(request.error))
    //    //{
    //    //    ErrorMessage.netError = request.error;
    //    //    SceneManager.LoadScene("ErrorScreen", LoadSceneMode.Single);
    //    //    canvas.SetActive(false);
    //    //}
    //    //else {
    //    //    uuid = request.text;
    //    //    Debug.Log("Registered new session: " + uuid);
    //    //}
    //}

    //records all mouse clicks
    //clickNum will be 1 for all buttons and the slice number for MRI slices
    public void RecordMouse(string buttonID, int clickNum)
    {
        MouseState click = gameObject.AddComponent<MouseState>();
        click.objectId = buttonID; //all buttons have an associated ID. See Unity scene for IDs
        click.downUp = clickNum; //1 is up click, 0 is down click. Added when puzzle was added, all buttons in models use 1
        mouseData.Add(click);

        //Mouse data is sent after the list has reach MOUSE_BUFFER_COUNT 
        if (mouseData.Count > MOUSE_BUFFER_COUNT)
        {
            //sendMouseCo = sendMouse();
            //StartCoroutine(sendMouseCo);
        }

    }

    //See SpatialState class for what data is recorded
    public void RecordSpatial(SpatialState objSpatial)
    {
        spatialData.Add(objSpatial);

        if (spatialData.Count > SPATIAL_BUFFER_COUNT)
        {
            //sendSpatialCo = SendSpatial();
            //StartCoroutine(sendSpatialCo);
        }
    }

    //See Tooltip class for what data is recorded
    public void RecordToolTip(ToolTipState newToolTip)
    {
        tooltipData.Add(newToolTip);

        if (tooltipData.Count > TOOLTIP_BUFFER_COUNT)
        {
            //sendToolTipCo = SendToolTip();
            //StartCoroutine(sendToolTipCo);
        }

    }

    //Sending of end session
    public void sendEndSession()
    {
        //sendEndSessionCo = EndSession();
        //StartCoroutine(sendEndSessionCo);
    }

    //IEnumerator<WWW> sendMouse()
    //{
    //    return MakeRequest(mouseData, _mousePath);
    //}

    /// <summary>
    /// Single method used to send data to the server for different states
    /// </summary>
    /// <typeparam name="T">Underlying type being sent</typeparam>
    /// <param name="dataArr"></param>
    /// <param name="path"></param>
    /// <returns></returns>
    //private IEnumerator<WWW> MakeRequest<T>(List<T> dataArr, string path) where T : UnityEngine.Object
    //{
    //    if (dataArr.Count <= 0)
    //    {
    //        Debug.Log("No data to send, ignoring request.", this); //Indicates there is an error with the data recording
    //    }
    //    else {
    //        // Do a defensive copy
    //        DataWrapper<T> dataObj = new DataWrapper<T>(dataArr); //See DataWrapper class below
    //        dataArr.Clear();

    //        string json = dataObj.ToJson(); //convert data to json string

    //        // Add headers for http request
    //        Dictionary<string, string> headers = new Dictionary<string, string>();
    //        headers.Add("Content-Type", "application/json");
    //        //headers.Add("Content-Length", json.Length.ToString());

    //        //Debug.Log(string.Format("{0}: \n{1}", ServiceURL + path, json), this);

    //        //WWW request = new WWW(ServiceURL + path + uuid, System.Text.Encoding.UTF8.GetBytes(json), headers);

    //        //yield return request;

    //        //if (!string.IsNullOrEmpty(request.error))
    //        //{
    //        //    canvas.SetActive(false);
    //        //    ErrorMessage.netError = request.error;
    //        //    SceneManager.LoadScene("ErrorScreen", LoadSceneMode.Single);
    //        //}
    //        //else
    //        //{
    //        //    Debug.Log("Data sent");

    //        //    //destroys the data after it has successfully sent
    //        //    foreach (T x in dataObj.data)
    //        //    {
    //        //        Destroy(x);
    //        //    }
    //        //}
    //    }
    //}

    //IEnumerator<WWW> SendSpatial()
    //{
    //    return MakeRequest(spatialData, _spatialPath);
    //}

    //IEnumerator<WWW> SendToolTip()
    //{
    //    return MakeRequest(tooltipData, _tooltipPath);
    //}

    //IEnumerator EndSession()
    //{
    //    SendAllData();

    //    EndState end = gameObject.AddComponent<EndState>();
    //    end.end = System.DateTime.Now.ToString("o");

    //    string json = JsonUtility.ToJson(end);

    //    Dictionary<string, string> headers = new Dictionary<string, string>();
    //    headers.Add("Content-Type", "application/json");
    //    //headers.Add("Content-Length", json.Length.ToString());

    //    Debug.Log(json);

    //    //WWW request = new WWW(_sessionEndPath + uuid, System.Text.Encoding.UTF8.GetBytes(json), headers);

    //    //yield return request;

    //    //if (!string.IsNullOrEmpty(request.error))
    //    //{
    //    //    canvas.SetActive(false);
    //    //    ErrorMessage.netError = request.error;
    //    //    SceneManager.LoadScene("ErrorScreen", LoadSceneMode.Single);
    //    //}
    //    //else {
    //    //    //Login screen is loaded after the user has successfully exited the program
    //    //    Debug.Log("End Session");
    //    //    canvas.SetActive(false);
    //    //    SceneManager.LoadScene("LoginScreen");
    //    //}
    //}

    //used with End session to send what data is left 
    public void SendAllData()
    {
        //sendToolTipCo = SendToolTip();
        //sendMouseCo = sendMouse();
        //sendSpatialCo = SendSpatial();
        //StartCoroutine(sendToolTipCo);
        //StartCoroutine(sendMouseCo);
        //StartCoroutine(sendSpatialCo);
    }

    [Serializable]
    private class DataWrapper<T> where T : UnityEngine.Object
    {
        public List<T> data;

        public DataWrapper(List<T> data)
        {
            // defensive copy, just in case.
            this.data = new List<T>(data);
            this.data.RemoveAll(it => it == null);
        }

        //Creating the json string from the data list
        public String ToJson()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("{ \"data\": [");
            if (data.Count > 0)
            {   // check for empty
                foreach (T value in data)
                {
                    builder.Append(JsonUtility.ToJson(value));
                    builder.Append(",");
                }
                builder.Remove(builder.Length - 1, 1);
            }
            builder.Append("]}");

            return builder.ToString();
        }
    }
    
    //Classes used in the above code for mouse, start and end data
    [Serializable]
    public class MouseState : MonoBehaviour
    {
        public string objectId;
        public string timestamp = System.DateTime.Now.ToString("o");
        public int downUp;
    }

    [Serializable]
    public class StartState : MonoBehaviour
    {
        public string start;
        public string userId;
        public string modelId;
    }

    [Serializable]
    public class EndState : MonoBehaviour
    {
        public string end;
    }

}