using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class testScript : MonoBehaviour
{
    public GameObject gmobject;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.T))
        {
            gmobject.SetActive(true);
            //Debug.Log("Object is active");
        }

        
        if (Input.GetKey(KeyCode.F))
        {
            gmobject.SetActive(false);
            //Debug.Log("Object is inactive");
        }
    }
}
