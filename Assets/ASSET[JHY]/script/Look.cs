using UnityEngine;

public class Look : MonoBehaviour
{
    public Transform target; // �ٶ� ��� ������Ʈ�� Transform

    void Update()
    {
        if (target != null)
        {
            // ����� ��ġ�� ���� �ٶ󺸱� (Y�� �̿��� ���� ����)
            Vector3 directionToTarget = target.position - transform.position;
            directionToTarget.y = 0; // Y ������ 0���� �����Ͽ� Y�� ȸ���� ����

            // ����� Y�� �̿��� ���� �����Ͽ� �ٶ󺸱� ���� ȸ�� ����
            Quaternion rotation = Quaternion.LookRotation(directionToTarget, Vector3.up);

            // �ش� ȸ���� ������Ʈ�� ����
            transform.rotation = rotation;
        }
    }
}
