using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemUI : MonoBehaviour
{
    public GameObject A;
    //public AudioSource b;
    public event Action onTriggerButton;
    public GameObject UiButton;
    public GameObject UiButton2;
    int a = 0;
    //public AudioSource b;

    private void Start()
    {
        UiButton.SetActive(false);
        UiButton2.SetActive(false);
    }
    private void OnCollisionStay(Collision collision)
    {
        if (a == 0)
            if (collision.gameObject.CompareTag("Player"))
            {
                UiButton.SetActive(true);
                if (Input.GetKey(KeyCode.E))
                {
                    Debug.Log("æ∆¿Ã≈€¿ª »πµÊ«ﬂΩ¿¥œ¥Ÿ: ");
                    A.SetActive(false);
                    //b.Play();
                    onTriggerButton?.Invoke();
                    UiButton.SetActive(false);
                    UiButton2.SetActive(true);
                    a++;

                }
            }

    }

    private void OnCollisionExit(Collision collision)
    {
        UiButton.SetActive(false);
    }




}
