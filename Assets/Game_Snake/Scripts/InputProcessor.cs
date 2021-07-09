using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputProcessor : MonoBehaviour
{
    public static InputProcessor input;
    private float moveHorizontal;
    private float moveVertical; 
    private bool pause;

    // Use this for initialization
    private void Awake()
    {
        Time.timeScale = 1;
        input = this;
    }

    // Update is called once per frame
    void Update () {
        Vector2 joystick = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick);
        moveHorizontal = joystick[0];
        moveVertical = joystick[1];
        pause = OVRInput.GetDown(OVRInput.RawButton.X);//return
        if (pause) {
            Time.timeScale = Time.timeScale == 0 ? 1 : 0;
        }
    }

    public float getHor(){
        return moveHorizontal;
    }
    public float getVer(){
        return moveVertical;
    }
}
