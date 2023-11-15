using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    public event Action onTriggerEnterEvent;
    public event Action onTriggerExitEvent;
   



    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("11111111111");
        onTriggerEnterEvent?.Invoke();
        
    }

    

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("2222222222");
        onTriggerExitEvent?.Invoke();
    }
}
