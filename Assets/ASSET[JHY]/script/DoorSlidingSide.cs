using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSlidingSide : MonoBehaviour
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
            if (Door.transform.localPosition.x >= 0.1f)
            {
                
                Door.transform.Translate(-0.01f, 0, 0);
            }
        }

        if (flag == false)
        {
            if (Door.transform.localPosition.x < 1.10f)
            {
                
                Door.transform.Translate(0.01f, 0, 0);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
<<<<<<< Updated upstream
        flag = true;
=======
        if (collision.gameObject.CompareTag("Player"))
        {
            if (Input.GetKey(Key))
            {
                GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("SFXv");
                flag = true;
                Debug.Log("�ȳ�");
                b.Play();
            }
        }

>>>>>>> Stashed changes
    }

    private void OnTriggerExit(Collider other)
    {
        flag = false;
    }
}
