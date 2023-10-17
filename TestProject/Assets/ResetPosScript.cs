using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPosScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject capsule;
    public void ResetBtnIsClicked()
    {
        capsule.transform.position = new Vector3(23.69f, 7.416873f, 23.05f);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //BtnIsClicked();
    }
}
