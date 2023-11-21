using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tr1 : MonoBehaviour
{
    public float speed = 2.0f;
    public GameObject A;
    private bool flag;
    private Vector3 C = new Vector3(0, 0, 1);
    private bool hasPlayed = false;
    AudioSource audio1;
    // Start is called before the first frame update
    void Start()
    {
       
        flag = false;
        audio1 = GetComponent<AudioSource>();

    }
    private void Awake() {
    }

    // Update is called once per frame
    private void Update() 
    {
        if (flag) {
            if (A.transform.position.z < 21.0f)
                    {
                A.transform.position += C * speed * Time.deltaTime;
            }
        }



    }
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player") && !hasPlayed)
        {
            flag = true;
            audio1.Play();
            Debug.Log("d");
        }

    }
} //end class
