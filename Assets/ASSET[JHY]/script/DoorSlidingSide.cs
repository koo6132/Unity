using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSlidingSide : MonoBehaviour
{
    bool flag;
    public GameObject Door;
    public KeyCode Key = KeyCode.G;
    public float Range = 0.5f;
    

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
            if (Door.transform.localPosition.x >= 0.3f)
            {

                Door.transform.Translate(-0.025f, 0, 0);
            }
        }

        if (flag == false)
        {
            if (Door.transform.localPosition.x < 1.1f)
            {

                Door.transform.Translate(0.025f, 0, 0);
            }
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (Input.GetKey(Key))
            {
                flag = true;
                Debug.Log("¾È³ç");
            }
        }

    }

    private void OnTriggerExit(Collider other)
    {
        flag = false;
    }
}
