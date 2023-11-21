using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSliding : MonoBehaviour
{
    bool flag;
    public GameObject Door;
    public KeyCode pickupKey = KeyCode.E;
    public float pickupRange = 0.5f;
    public GameObject UiButton;
    int a = 0;
    public GameObject A;

    // Start is called before the first frame update
    void Start()
    {
        flag = false;
        UiButton.SetActive(false);
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

        if (Input.GetKeyDown(pickupKey))
        {
            flag = true;
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (a == 0)
            if (collision.gameObject.CompareTag("Player"))
            {
<<<<<<< Updated upstream
                UiButton.SetActive(true);
                if (Input.GetKey(KeyCode.E))
                {
                    Debug.Log("PRESS E");
                    A.SetActive(false);
                    //b.Play();
                    
                    UiButton.SetActive(false);
                    a++;
=======
                b.volume = PlayerPrefs.GetFloat("SFXv");
                flag = true;
                Debug.Log("¾È³ç");
                b.Play();
            }
        }
>>>>>>> Stashed changes

                }
            }

    }

    private void OnTriggerEnter(Collider other)
    {
        //flag = true;

        if (Input.GetKeyDown(pickupKey))
        {
            flag = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        flag = false;
        UiButton.SetActive(false);
    }


}
