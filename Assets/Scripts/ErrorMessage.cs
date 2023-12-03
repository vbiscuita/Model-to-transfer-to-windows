using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Text.RegularExpressions;
using UnityEngine.SceneManagement;

public class ErrorMessage : MonoBehaviour {

    //If networking returns an error, this scene is loaded and the error returned is displayed
    public Text errorMessage;
    public static string netError;

	// Use this for initialization
	void Start () {
        errorMessage.text = netError;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
