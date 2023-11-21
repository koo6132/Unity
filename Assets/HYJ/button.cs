using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    public GameObject A;
    public AudioSource b;
    public event Action onTriggerButton;
    public GameObject UiButton;
    int a = 0;
    public GameObject Button;

    private void Start()
    {
        UiButton.SetActive(false);
    }
    private void OnCollisionStay(Collision collision)
    {
        if(a==0)
        if (collision.gameObject.CompareTag("Player")) 
        {
            UiButton.SetActive(true);
            if (Input.GetKey(KeyCode.E))
            {
                Button.transform.position = new Vector3(0f, 0.5f, 0f);
                Debug.Log("¹®¿­¸²");
                A.SetActive(false);
                b.Play();
                onTriggerButton?.Invoke();
                UiButton.SetActive(false);
                a++;

            }
        }
        
    }
 
    private void OnCollisionExit(Collision collision)
    {
        UiButton.SetActive(false);
    }




}
