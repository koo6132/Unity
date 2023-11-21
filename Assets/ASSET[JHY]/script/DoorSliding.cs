using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSliding : MonoBehaviour
{
    bool flag;
    public GameObject Door;
    public KeyCode Key = KeyCode.G;
    public float Range = 0.5f;
    public AudioSource b;


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

                Door.transform.Translate(-0.025f, 0, 0);
            }
        }

        if (flag == false)
        {
            if (Door.transform.localPosition.x < -1.40f)
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
                b.Play();
            }
        }

    }

    private void OnTriggerExit(Collider other)
    {
        flag = false;
    }
}
