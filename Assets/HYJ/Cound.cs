using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cound : MonoBehaviour
{
    public Transform character; // 캐릭터의 Transform
    public Transform target; // 타겟 오브젝트의 Transform
    public AudioSource audioSource; // 사용할 AudioSource

    public float maxDistance = 10f; // 최대 거리
    public float minDistance = 1f; // 최소 거리

    void Update()
    {
        // 캐릭터와 타겟 사이의 거리 계산
        float distance = Vector3.Distance(character.position, target.position);

        // 거리에 따라 소리 크기 조절
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
            // 최대 거리와 최소 거리 사이에 있는 경우 선형 보간을 사용하여 볼륨 조절
            float volume = 1f - (distance - minDistance) / (maxDistance - minDistance);
            audioSource.volume = volume;
        }
    }
}
