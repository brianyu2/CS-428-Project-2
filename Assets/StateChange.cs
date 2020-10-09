using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateChange : MonoBehaviour
{
    Animator anima;
    public AudioSource mySound;

    // Start is called before the first frame update
    void Start()
    {
        anima = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anima.SetTrigger("sayhi");
            mySound.Play();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            anima.SetTrigger("dodance");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            anima.SetTrigger("sitdown");
        }
    }
}
