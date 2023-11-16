using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knife_ratate : MonoBehaviour
{
    public float ratateSpeed;


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * ratateSpeed * Time.deltaTime, Space.World);
    }

    
}
