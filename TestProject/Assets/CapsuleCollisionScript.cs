using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class CapsuleCollisionScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int hpCount = 5; 
    public void OnCollisionEnter()
    {
        
        hpCount--;
        if(hpCount <= 0 )
        {
            Debug.Log("You're dead!");
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
