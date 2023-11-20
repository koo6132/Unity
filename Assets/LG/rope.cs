using System.Collections;
using UnityEngine;

public class rope : MonoBehaviour
{
   
    public GameObject A;
    public GameObject B;
    public GameObject C;
    public GameObject player;      
    public GameObject tr;
    AudioSource D;

    bool flag = false;

    // Start is called before the first frame update
    void Start()
    {
        A.SetActive(true);
        B.SetActive(true);
        C.SetActive(false);
        D = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
            int a = player.GetComponent<item>().itemCount;
            if (a == 1)
        {
            bool P = tr.GetComponent<trigger2>().P;
            if (P)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    StartCoroutine(DoSond());

                }
            }
        }
    }    

    IEnumerator DoSond()
    {
        if (!flag)
        {
            flag = true;
            Debug.Log("asd");
            D.Play();
            yield return new WaitForSeconds(3.0f);
            A.SetActive(false);
            B.SetActive(false);
            C.SetActive(true);
        }

    }
}
