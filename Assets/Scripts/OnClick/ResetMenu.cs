using UnityEngine;

public class ResetMenu : MonoBehaviour {
    public GameObject parent;

    public void Click()
    {
        parent.GetComponent<OnButtonClick>().resetOnClick();
    }
}
