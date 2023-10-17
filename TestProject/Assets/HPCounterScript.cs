using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HPCounterScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Text HPCount;
    public CapsuleCollisionScript collisionScriptObject;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HPCount.text = $"HP left: {collisionScriptObject.hpCount}";
    }
}
