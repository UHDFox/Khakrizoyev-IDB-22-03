using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript1 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gmobject;

    public void BtnIsClicked()
    {
        if (gmobject.active == true)
        {
            Debug.Log("Game object is active");
        }
        else
        {
            Debug.Log("Game object is inactive or it wasn't set");
        }
    }

    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
