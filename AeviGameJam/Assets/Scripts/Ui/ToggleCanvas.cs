using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleCanvas : MonoBehaviour {

    public void Toggle()
    {
        GetComponent<Canvas>().enabled = !GetComponent<Canvas>().enabled;
    }
}
