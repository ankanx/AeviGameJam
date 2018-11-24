using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMap : MonoBehaviour {


    public GameObject Camera;

    public void zoomIn()
    {
        Camera.GetComponent<Camera>().fieldOfView -= 5; 
    }

    public void zoomOut()
    {
        Camera.GetComponent<Camera>().fieldOfView += 5;
    }
 }
    
