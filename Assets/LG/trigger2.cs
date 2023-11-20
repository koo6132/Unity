using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger2 : MonoBehaviour
{
    public bool P;
    // Start is called before the first frame update
    void Start()
    {
        P = false;
    }

    // Update is called once per frame
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            P = true;
            //Debug.Log("π‚¿Ω");
        }
    }
}
