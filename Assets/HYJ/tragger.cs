using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    public event Action onTriggerEnterEvent;
    public event Action onTriggerExitEvent;
    public GameObject Uione;
    private bool a;
    private void Start()
    {
        Uione.SetActive(false);
        a = true;
    }




    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("11111111111");
        onTriggerEnterEvent?.Invoke();
        if (a) 
        {
            Uione.SetActive(true);
        }
            a = false;
        
    }

    private void OnCollisionStay(Collision collision)
    {
        
    }


    private void OnCollisionExit(Collision collision)
    {
        a = false;
        Debug.Log("³ª°¬½À´Ï´Ù");
        onTriggerExitEvent?.Invoke();
 
        Uione.SetActive(false) ;
      
        
    }
}
