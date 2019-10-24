using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ani : MonoBehaviour {
    private Animator ABC;

    // Use this for initialization
    void Start()
    {
        ABC = gameObject.GetComponent<Animator>();
    }

 
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            ABC.SetTrigger("吃飯觸發器");
        }
        if (Input.GetKey(KeyCode.R))
        {
            ABC.SetBool("跑步開關", true);
        }
        else
        {
            ABC.SetBool("跑步開關", false);
        }
    }
}

