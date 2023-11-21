using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AAA2 : MonoBehaviour
{
    public GameObject ON;
    public GameObject OFF;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.name == "Kill")
    //    {
    //        OFF.SetActive(false);
    //        ON.SetActive(true);
    //    }
    //}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Kill"))
        {
            Debug.Log("¹Ì¿¬½Ã ¤µ¤²");
            OFF.SetActive(false);
            ON.SetActive(true);
        }
    }


}
