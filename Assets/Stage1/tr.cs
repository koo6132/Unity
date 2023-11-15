using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tr : MonoBehaviour
{
    public float speed = 5.0f;
    public GameObject A;
    public GameObject B;
    private bool flag;
    private bool flag2;
    private Vector3 C = new Vector3(0, 0, -1);
    // Start is called before the first frame update
    void Start()
    {
       
        flag = false;
        flag2 = false;

    }
    private void Awake() {
    }

    // Update is called once per frame
    private void Update() 
    {
        if (flag) {
            if (A.transform.position.z > 16.5f) 
                    {
                A.transform.position += C * speed * Time.deltaTime;
            }
        }
        if (flag2) {
            B.SetActive(true);
        }



    }
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player"))
        {
            flag = true;
            flag2 = true;
            Debug.Log("d");
        }

    }
} //end class
