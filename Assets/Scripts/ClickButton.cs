using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickButton : MonoBehaviour
{
    public string back;
    public string again;
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.RawButton.A))
            UnityEngine.SceneManagement.SceneManager.LoadScene(back);
        else if(OVRInput.GetDown(OVRInput.RawButton.B))
            UnityEngine.SceneManagement.SceneManager.LoadScene(again);
    }
}
