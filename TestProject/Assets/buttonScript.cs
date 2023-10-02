using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Text textToEdit;

    void Start()
    {
        textToEdit = GetComponent<Text>();
    }
    

    // Update is called once per frame
    void Update()
    {
        textToEdit.text = "capybara";
    }
}
