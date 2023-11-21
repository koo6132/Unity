using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tr2 : MonoBehaviour
{
    public float speed = 10f;
    public GameObject A;
    public GameObject B;
    private bool flag;
    private Vector3 C = new Vector3(0, 0, -10);
    private bool hasPlayed = false;
    AudioSource audio1;
    // Start is called before the first frame update
    void Start()
    {
   
        flag = false;
        audio1 = GetComponent<AudioSource>();

    }
    // Update is called once per frame
    private void Update() 
    {
        if (flag)
        {
            if (A.transform.position.z > -35.5f)
            {
                A.transform.position += C * speed * Time.deltaTime;
            }
        }



    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && !hasPlayed)
        {
            flag = true;
            audio1.Play();
            Debug.Log("d");

            StartCoroutine(RotateDelay());
        }

    }

    IEnumerator RotateDelay()
    {
        yield return new WaitForSeconds(3f);

        B.transform.Rotate(Vector3.up, 45f);
    }
} //end class
