using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemRotate : MonoBehaviour
{
    public float ratateSpeed;
   

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * ratateSpeed * Time.deltaTime, Space.World);
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    if(other .tag == "Player")
    //    {
    //        gameObject.SetActive(false);
    //    }
    //}
}
