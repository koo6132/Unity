using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Example : MonoBehaviour
{
    // 타겟
    public Transform target;

    // 머터리얼
    public Material glassMat;

    // 임계 값
    public float thresholdDist = 10f;

    private void Update()
    {
        // 타겟과의 거리 구함
        float distToTarget = GetDistanceToTarget();

        // 리맵값 구함
        float remapValue = Remap(distToTarget, thresholdDist, 0, 0, 1);

        // 1보다 크면 1 0보다 작으면 0
        if (remapValue >= 1)
            remapValue = 1;
        else if (remapValue < 0)
            remapValue = 0;

        Color color = glassMat.color;

        color.a = remapValue;

        glassMat.color = color;
    }

    /// <summary>
    /// 타겟과의 거리를 구하는 함수
    /// </summary>
    /// <returns>거리값</returns>
    private float GetDistanceToTarget()
    {
        float result = Vector3.Distance(transform.position, target.position);
        return result;
    }

    // 리맵 함수 ex)  섭씨가 3일 때 화씨값을 구하시오  / 섭씨 1  10      화씨 33.8    50
    public float Remap(float from, float fromMin, float fromMax, float toMin, float toMax)
    {
        float fromAbs = from - fromMin;
        float fromMaxAbs = fromMax - fromMin;

        float normal = fromAbs / fromMaxAbs;

        float toMaxAbs = toMax - toMin;
        float toAbs = toMaxAbs * normal;

        float to = toAbs + toMin;

        return to;
    }
}


