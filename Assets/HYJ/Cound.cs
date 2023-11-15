using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cound : MonoBehaviour
{
    public Transform character; // ĳ������ Transform
    public Transform target; // Ÿ�� ������Ʈ�� Transform
    public AudioSource audioSource; // ����� AudioSource

    public float maxDistance = 10f; // �ִ� �Ÿ�
    public float minDistance = 1f; // �ּ� �Ÿ�

    void Update()
    {
        // ĳ���Ϳ� Ÿ�� ������ �Ÿ� ���
        float distance = Vector3.Distance(character.position, target.position);

        // �Ÿ��� ���� �Ҹ� ũ�� ����
        if (distance > maxDistance)
        {
            audioSource.volume = 0f;
        }
        else if (distance < minDistance)
        {
            audioSource.volume = 1f;
        }
        else
        {
            // �ִ� �Ÿ��� �ּ� �Ÿ� ���̿� �ִ� ��� ���� ������ ����Ͽ� ���� ����
            float volume = 1f - (distance - minDistance) / (maxDistance - minDistance);
            audioSource.volume = volume;
        }
    }
}
