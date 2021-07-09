using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PutupPencil : MonoBehaviour
{
    public GameObject this_canvas;
    public GameObject next_canvas;
    float inity;

    private void Start()
    {
        inity = transform.position.y;
    }
    private void Update()
    {
        if(transform.position.y>inity)
        {
            this_canvas.SetActive(false);
            Invoke("nextCanvas", 1);
        }
    }
    void nextCanvas()
    {
        next_canvas.SetActive(true);
    }
}
