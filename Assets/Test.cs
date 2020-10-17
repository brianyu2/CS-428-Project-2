using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Test : MonoBehaviour
{
    public GameObject button;

    // Start is called before the first frame update
    void Start()
    {
        //button.GameObject.Find("Button");
        button.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        button.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);

    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {

        Debug.Log("Pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {

        Debug.Log("Releassed");

    }
}
