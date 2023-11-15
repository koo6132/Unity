using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class trtr : MonoBehaviour
{
    public event Action onTriggerTimeEnterEvent;
    public event Action onTriggerTimeExitEvent;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("333333");
        onTriggerTimeEnterEvent?.Invoke();
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("44444444");
        onTriggerTimeExitEvent?.Invoke();
    }
}
