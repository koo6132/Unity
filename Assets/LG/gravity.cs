using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravity : MonoBehaviour
{
    public Rigidbody A;
    public Rigidbody B;
    public Rigidbody C;
    public Rigidbody D;
    public Rigidbody E;
    public Rigidbody F;
    public Rigidbody G;
    public Rigidbody H;
    public Rigidbody I;
    public Rigidbody J;
    public Rigidbody K;
    public Rigidbody L;
    public Rigidbody M;
    public Rigidbody N;
    public Rigidbody P;
    public AudioSource BB;
    bool asdf = false;

    // Start is called before the first frame update
    void Start()
    {
        asdf = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {      
            Debug.Log("ø÷¿Ã∑° ææπﬂ");
            A.useGravity = true;
            B.useGravity = true;
            C.useGravity = true;
            D.useGravity = true;
            E.useGravity = true;
            F.useGravity = true;
            G.useGravity = true;
            H.useGravity = true;
            I.useGravity = true;
            J.useGravity = true;
            K.useGravity = true;
            L.useGravity = true;
            M.useGravity = true;
            N.useGravity = true;
            P.useGravity = true;
            if (asdf)
            {
                BB.Play();
                asdf = false;
            }
        }


    }
}
