using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkOpener : MonoBehaviour {

    public void OpenLink(string URL)
    {
        Application.OpenURL(URL);
    }
}
