using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Walk: MonoBehaviour {
    public GameObject uigame;

    private bool isPlayerInside;
    private float timeToShowUI = 4f;
    private float currentTime = 0f;
    // Start is called before the first frame update
    void Start()
    {
        uigame.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayerInside)
        {
            currentTime += Time.deltaTime;

            if (Input.GetKey(KeyCode.F15))
            {
                Debug.Log("100");
                uigame.SetActive(false);
                currentTime = 0f; // E 키를 누르면 시간 초기화
            }

            if (currentTime >= timeToShowUI)
            {
                uigame.SetActive(false);
                isPlayerInside = false;
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            uigame.SetActive(true);
            isPlayerInside = true;
        }
    }
}
