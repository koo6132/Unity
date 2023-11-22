using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ggamtrigger : MonoBehaviour
{
    public GameObject A;
    public AudioSource B;
    bool asdf = false;
    // Start is called before the first frame update
    void Start()
    {
        asdf = true;
         A.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (asdf)
        {
            A.SetActive(true);
            B.Play();
            asdf = false;
        }


        
    }
}
