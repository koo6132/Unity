using UnityEngine;

public class item2cha : MonoBehaviour
{
    // �������� ȹ���� Ű
    public KeyCode pickupKey = KeyCode.E;
    public GameObject ui11;
    int a = 0;

    // ������ ȹ�� ������ �Ÿ�
    public float pickupRange = 1f;

    public int itemCount;

    private GameObject equippedLight;
    private void Start()
    {
        ui11.SetActive(false);
    }


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
    private void OnTriggerStay(Collider other)
    {
        if(a == 0)
        {
            if (other.gameObject.CompareTag("item"))
            {
                ui11.SetActive(true);
                if (Input.GetKey(pickupKey))
                {
                    ui11.SetActive(false);
                    a++;
                }
            }
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("item"))
        {
            ui11.SetActive(false);
        }
    }
}


