using System.Collections;
using UnityEngine;

public class rope : MonoBehaviour
{
   
    public GameObject A;
    public GameObject B;
    public GameObject C;
    public GameObject player;      
    public GameObject tr;
    public GameObject ui;
    public GameObject ui2;
    AudioSource D;

    int a = 0;

    bool flag = false;
    bool on = false;

    // Start is called before the first frame update
    void Start()
    {
        A.SetActive(true);
        B.SetActive(true);
        C.SetActive(false);
        ui.SetActive(false);
        ui2.SetActive(false);
        D = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        a = player.GetComponent<item2cha>().itemCount; 
        if (a == 1)
        {
            bool P = tr.GetComponent<trigger2>().P;
            if (P)
            {
                if (Input.GetKeyDown(KeyCode.E) && on)
                {
                    ui.SetActive(false);
                    StartCoroutine(DoSond());
                }
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.E) && on)
            {
                ui.SetActive(false);
                ui2.SetActive(true);
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
            yield return new WaitForSeconds(4.2f);
            A.SetActive(false);
            B.SetActive(false);
            C.SetActive(true);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        ui.SetActive(true);

        on = true;
    }

    private void OnTriggerExit(Collider other)
    {
        ui.SetActive(false);
        ui2.SetActive(false);
        on = false;
    }
}
