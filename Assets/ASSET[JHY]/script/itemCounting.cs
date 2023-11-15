using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemCounting : MonoBehaviour
{
    public int itemCount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other .tag == "item")
        {
            itemCount++;
            other.gameObject.SetActive(false);
        }
    }
}
