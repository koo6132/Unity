using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    // �������� ȹ���� Ű
    public KeyCode pickupKey = KeyCode.E;

    // ������ ȹ�� ������ �Ÿ�
    public float pickupRange = 0.1f;

    public int itemCount;

    private GameObject equippedLight;

    void Update()
    {
        // E Ű�� ������ ��
        if (Input.GetKeyDown(pickupKey))
        {
            // ��ó�� �ִ� ��� Collider ��������
            Collider[] colliders = Physics.OverlapSphere(transform.position, pickupRange);

            // ��ó�� �ִ� ������ ã��
            foreach (Collider collider in colliders)
            {
                // �����ۿ� Item �±װ� �ִ��� Ȯ��
                if (collider.CompareTag("item"))
                {
                    // ������ ȹ�� �Լ� ȣ��
                    PickupItem(collider.gameObject);
                }
            }

            foreach (Collider collider in colliders)
            {
                // �����ۿ� Item �±װ� �ִ��� Ȯ��
                if (collider.CompareTag("Light"))
                {
                    // ������ ȹ�� �Լ� ȣ��
                    PickupItem(collider.gameObject);
                }
            }
        }
    }

    void PickupItem(GameObject item)
    {
        // �������� ���⼭ ó�� (��: �κ��丮�� �߰�, ȿ�� �ο� ��)
        Debug.Log("�������� ȹ���߽��ϴ�: " + item.name);

        // �������� ��Ȱ��ȭ�ϰų� ������ ���� �ֽ��ϴ�.
        item.SetActive(false);
        // �Ǵ� Destroy(item); ��� ����

       itemCount++;

       EquipItem(item);
    }

    void EquipItem(GameObject item)
    {
        if (item.CompareTag("Light"))
        {
            Debug.Log("�������� �����߽��ϴ�.");
            equippedLight = item;
        }
    }
}
