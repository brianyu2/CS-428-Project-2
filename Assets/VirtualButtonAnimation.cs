using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButtonAnimation : MonoBehaviour
{
    public GameObject button;
    Animator anima;
    public AudioSource mySound;

    // Start is called before the first frame update
    void Start()
    {
        anima = GetComponent<Animator>();
        button = GameObject.Find("AnimationButton");
        button.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        button.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        anima.SetTrigger("sayhi");
        mySound.Play();
        Debug.Log("Pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Released");
    }
}
