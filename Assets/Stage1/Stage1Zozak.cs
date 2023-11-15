using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TUTO : MonoBehaviour {
    public GameObject uigame;
    public GameObject uigame1;

    private bool isPlayerInside;
    private float timeToShowUI = 5f;
    private float currentTime = 0f;
    // Start is called before the first frame update
    void Start() {
        uigame.SetActive(false);
        uigame1.SetActive(false);
    }

    // Update is called once per frame
    void Update() {
        if (isPlayerInside) {
            currentTime += Time.deltaTime;

            if (Input.GetKey(KeyCode.F15)) {
                Debug.Log("100");
                uigame.SetActive(false);
                uigame1.SetActive(false);
                currentTime = 0f; // E 키를 누르면 시간 초기화
            }

            if (currentTime >= timeToShowUI) {
                uigame.SetActive(false);
                uigame1.SetActive(false);
                isPlayerInside = false;
            }
        }
    }
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            uigame.SetActive(true);
            uigame1.SetActive(true);
            isPlayerInside = true;
        }
    }
    private void OnTriggerExit(Collider other) {
        if (other.gameObject.tag == "Player") {
            uigame.SetActive(false);
            uigame1.SetActive(false);
            isPlayerInside = false;
        }
    }
}
