using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideHorror : MonoBehaviour
{
    bool flag;
    public GameObject Horror;
    public float moveSpeed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        flag = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (flag)
        {
            if (Horror.transform.localPosition.z >= -0.5f)
            {
                Horror.transform.Translate(0, 0, moveSpeed);
            }
        }
        else
        {
            if (Horror.transform.localPosition.z < -1.5f)
            {
                Horror.transform.Translate(0, 0, -moveSpeed);
            }
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        flag = true;
    }

    private void OnTriggerExit(Collider other)
    {
        flag = false;
    }
}
