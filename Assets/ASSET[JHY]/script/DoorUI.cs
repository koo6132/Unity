using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorUI : MonoBehaviour
{
    public event Action onTriggerButton;
    public GameObject UiButton;
    //int a = 0;

    private void Start()
    {
        UiButton.SetActive(false);
    }
    private void OnCollisionStay(Collision collision)
    {
        //if (a == 0)
            if (collision.gameObject.CompareTag("Player"))
            {
                UiButton.SetActive(true);
                if (Input.GetKey(KeyCode.E))
                {
                    Debug.Log("UI open");
                    onTriggerButton?.Invoke();
                    UiButton.SetActive(false);
                //a++;

            }
            }

    }

    private void OnCollisionExit(Collision collision)
    {
        UiButton.SetActive(false);
    }
}
