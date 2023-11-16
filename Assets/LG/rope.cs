using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rope : MonoBehaviour
{
   
    public GameObject A;
    public GameObject B;
    public GameObject C;
    public GameObject player;      
    public GameObject tr;
    public AudioClip D;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        A.SetActive(true);
        B.SetActive(true);
        C.SetActive(false);
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
            int a = player.GetComponent<item>().itemCount;
            if (a == 1)
        {
            bool P = tr.GetComponent<trigger2>().P;
            if (P)
            {
                Interact();
            }
        }


    }
    void Interact()
    {
        
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("asd");
            A.SetActive(false);
            B.SetActive(false);
            C.SetActive(true);
            audioSource.clip = D;
            audioSource.Play();
           
        }

    }
   
    
}
