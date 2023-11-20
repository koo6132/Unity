using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundUI : MonoBehaviour
{
    
    public AudioSource b;

    private void Start()
    {
        
    }
    private void OnCollisionStay(Collision collision)
    {
            if (collision.gameObject.CompareTag("Player"))
            {
                
                if (Input.GetKey(KeyCode.E))
                {
                Debug.Log("사운드 재생");
                    
                    b.Play();
                    

                }
            }

    }

    private void OnCollisionExit(Collision collision)
    {
       
    }




}
