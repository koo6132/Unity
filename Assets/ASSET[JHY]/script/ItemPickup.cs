using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    // 아이템을 획득할 키
    public KeyCode pickupKey = KeyCode.E;

    // 아이템 획득 가능한 거리
    public float pickupRange = 0.1f;

    public int itemCount;

    private GameObject equippedLight;

    void Update()
    {
        // E 키를 눌렀을 때
        if (Input.GetKeyDown(pickupKey))
        {
            // 근처에 있는 모든 Collider 가져오기
            Collider[] colliders = Physics.OverlapSphere(transform.position, pickupRange);

            // 근처에 있는 아이템 찾기
            foreach (Collider collider in colliders)
            {
                // 아이템에 Item 태그가 있는지 확인
                if (collider.CompareTag("item"))
                {
                    // 아이템 획득 함수 호출
                    PickupItem(collider.gameObject);
                }
            }

            foreach (Collider collider in colliders)
            {
                // 아이템에 Item 태그가 있는지 확인
                if (collider.CompareTag("Light"))
                {
                    // 아이템 획득 함수 호출
                    PickupItem(collider.gameObject);
                }
            }
        }
    }

    void PickupItem(GameObject item)
    {
        // 아이템을 여기서 처리 (예: 인벤토리에 추가, 효과 부여 등)
        Debug.Log("아이템을 획득했습니다: " + item.name);

        // 아이템을 비활성화하거나 제거할 수도 있습니다.
        item.SetActive(false);
        // 또는 Destroy(item); 사용 가능

       itemCount++;

       EquipItem(item);
    }

    void EquipItem(GameObject item)
    {
        if (item.CompareTag("Light"))
        {
            Debug.Log("손전등을 장착했습니다.");
            equippedLight = item;
        }
    }
}
