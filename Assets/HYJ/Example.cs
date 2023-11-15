using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Example : MonoBehaviour
{
    // Ÿ��
    public Transform target;

    // ���͸���
    public Material glassMat;

    // �Ӱ� ��
    public float thresholdDist = 10f;

    private void Update()
    {
        // Ÿ�ٰ��� �Ÿ� ����
        float distToTarget = GetDistanceToTarget();

        // ���ʰ� ����
        float remapValue = Remap(distToTarget, thresholdDist, 0, 0, 1);

        // 1���� ũ�� 1 0���� ������ 0
        if (remapValue >= 1)
            remapValue = 1;
        else if (remapValue < 0)
            remapValue = 0;

        Color color = glassMat.color;

        color.a = remapValue;

        glassMat.color = color;
    }

    /// <summary>
    /// Ÿ�ٰ��� �Ÿ��� ���ϴ� �Լ�
    /// </summary>
    /// <returns>�Ÿ���</returns>
    private float GetDistanceToTarget()
    {
        float result = Vector3.Distance(transform.position, target.position);
        return result;
    }

    // ���� �Լ� ex)  ������ 3�� �� ȭ������ ���Ͻÿ�  / ���� 1  10      ȭ�� 33.8    50
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


