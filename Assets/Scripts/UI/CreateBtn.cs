using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPopUpBtn : MonoBehaviour
{
    public GameObject PopUpUI;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void PopUpClick()
    {
        if(PopUpUI.activeSelf == false)
        {
        PopUpUI.SetActive(true);
        }
    }
}
