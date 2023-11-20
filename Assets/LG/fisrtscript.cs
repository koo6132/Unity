using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class fisrtscript : MonoBehaviour
{
    public GameObject A;
    
    // Start is called before the first frame update
    void Start()
    {
        A.SetActive(true);
        StartCoroutine(Aaaaaa());
    }

    // Update is called once per frame
    void Update()
    {
    }

    
    private IEnumerator Aaaaaa() 
    {
        
        yield return new WaitForSecondsRealtime(10f);
        A.SetActive(false);
    }
    
}
