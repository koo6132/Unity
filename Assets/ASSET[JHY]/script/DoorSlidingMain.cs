using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSlidingMain : MonoBehaviour
{
    public GameObject Door;
    public int requiredItems = 3; // 플레이어가 획득해야 하는 아이템의 수
    private int collectedItems = 0; // 플레이어가 현재 획득한 아이템의 수

    // Start is called before the first frame update
    void Start()
    {
        CloseDoor();
    }

    // Update is called once per frame
    void Update()
    {
        if (collectedItems >= requiredItems)
        {
            OpenDoor();
        }
        else
        {
            CloseDoor();
        }
    }


 

    void OpenDoor()
    {
        if (Door.transform.localPosition.x >= -2.3f)
        {
            Door.transform.Translate(-0.01f, 0, 0);
        }
    }

    void CloseDoor()
    {
        if (Door.transform.localPosition.x < -1.40f)
        {
            Door.transform.Translate(0.01f, 0, 0);
        }
    }
}
