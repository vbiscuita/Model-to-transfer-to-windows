using UnityEngine;
using System.Collections;

public class StartSession : MonoBehaviour {
    public static string username;
    public GameObject network;

    //username set from login in screen, sent to networking to start session on start of this scene

	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(this.gameObject);
        network.GetComponent<NetworkService>().StartSession(username);
	}
	
}
