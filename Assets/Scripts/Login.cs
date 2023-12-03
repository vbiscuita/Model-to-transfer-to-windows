using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Text.RegularExpressions;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Login : MonoBehaviour
{
    public InputField username;
    public InputField verifyUsername;

    public Button loginButton;

    public GameObject missingInfo;
    public GameObject errorMismatch;
    public GameObject errorWesternID;

    private EventSystem system;
    private Regex regexWesternId = new Regex(@"^[a-zA-Z]+\d*$");
    private Regex regexStudentNumber = new Regex(@"\d{9}");

    void Start()
    {
        system = EventSystem.current;
    }

    void Update()
    {
        //For using tab to go between the first input box and the second
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            Selectable next = system.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnDown();

            if (next != null)
            {
                InputField inputfield = next.GetComponent<InputField>();
                if (inputfield != null)
                    inputfield.OnPointerClick(new PointerEventData(system));

                system.SetSelectedGameObject(next.gameObject, new BaseEventData(system));
            }

            //Here is the navigating back part:
            else
            {
                next = Selectable.allSelectables[0];
                system.SetSelectedGameObject(next.gameObject, new BaseEventData(system));
            }
        }

        //So enter can be used as the "click" on login button
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            LoginClick();
        }
    }

    public void LoginClick()
    {
        missingInfo.SetActive(false);
        errorMismatch.SetActive(false);
        errorWesternID.SetActive(false);

        string usernameText = username.text.Trim();
        string verifyText = verifyUsername.text.Trim();

        //first type of error, input boxes are empty
        if (usernameText == "" && verifyText == "")
        {
            missingInfo.SetActive(true);
        }
        //second type of error, input boxes don't match
        else if (usernameText != verifyText)
        {
            errorMismatch.SetActive(true);
        }
        else if (usernameText == verifyText)
        {
            if (regexStudentNumber.IsMatch(usernameText)
                || !regexWesternId.IsMatch(usernameText))
            {
                // They put in their student number -- no!
                // or they wrote an invalid western id -- also no!
                errorWesternID.SetActive(true);
            }
            else
            {
                // The username is value! :)
                StartSession.username = usernameText;
                SceneManager.LoadScene("Model3DFullMRI");
            }
        }
    }
}