using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSlidingopen : MonoBehaviour
{
    bool flag;
    public GameObject Door;

    // Start is called before the first frame update
    void Start()
    {
        flag = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (flag == true)
        {
            if (Door.transform.localPosition.x >= -2.3f)
            {
                
                Door.transform.Translate(-0.01f, 0, 0);
            }
        }

        if (flag == false)
        {
            if (Door.transform.localPosition.x < -1.40f)
            {
                
                Door.transform.Translate(0.01f, 0, 0);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        flag = true;
    }

    
}
