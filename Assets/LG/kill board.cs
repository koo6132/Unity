using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killboard : MonoBehaviour
{
    public GameObject A;
    // Start is called before the first frame update
    void Start()
    {
        A.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("FLoor"))
        {
            Debug.Log("½Î¤Ó¹ß");
            A.SetActive(false);
        }
        
    }
}
