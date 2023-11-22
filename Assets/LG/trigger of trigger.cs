using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggeroftrigger : MonoBehaviour
{
    public GameObject A;
    // Start is called before the first frame update
    void Start()
    {
        A.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            A.SetActive(true);
        }
    }


}    
