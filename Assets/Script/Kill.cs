using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kill : MonoBehaviour
{
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Kill"))
        {
            SceneManager.LoadScene("Result");
            Debug.Log("2¹ø");
        }
    }
<<<<<<< Updated upstream
=======
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Kill")) 
        {
            SceneManager.LoadScene("Result");
            Debug.Log("2¹ø");
        }
    }
>>>>>>> Stashed changes
}
