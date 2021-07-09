using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerOpen : MonoBehaviour
{
    public GameObject openobj;
    public GameObject next_canvas;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Hand")
        {
            this.gameObject.SetActive(false);
            openobj.SetActive(true);
            Invoke("nextCanvas", 1);
        }
    }
    void nextCanvas(){
        next_canvas.SetActive(true);
    }
}
