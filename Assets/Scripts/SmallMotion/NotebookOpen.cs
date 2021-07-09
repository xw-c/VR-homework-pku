using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotebookOpen : MonoBehaviour
{
    public GameObject this_canvas;
    public GameObject next_canvas;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Hand")
        {
            this_canvas.SetActive(false);
            transform.Rotate(0, 0, 180);
            Invoke("nextCanvas", 1);
        }
    }
    void nextCanvas(){
        next_canvas.SetActive(true);
    }
}
