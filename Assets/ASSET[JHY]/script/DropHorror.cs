using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropHorror : MonoBehaviour
{
    bool flag;
    public GameObject Horror;

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
            if (Horror.transform.position.y >= 6f)
            {

                Horror.transform.Translate(0, 5f, 0);
            }
        }

        if (flag == false)
        {
            if (Horror.transform.position.y < 5f)
            {

                Horror.transform.Translate(0, 2f, 0);
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
