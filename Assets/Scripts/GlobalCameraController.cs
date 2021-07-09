using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalCameraController : MonoBehaviour
{
    private float w;
    // Start is called before the first frame update
    void Start()
    {
        w = GlobalConfig.config.rotate_speed;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        float ver = w *　GlobalInputProcessor.input.getVer();
        float hor = w *　GlobalInputProcessor.input.getHor();
        transform.Rotate(-ver,hor,0);
        // Debug.DrawRay(transform.position, Input.mousePosition);
    }
}
