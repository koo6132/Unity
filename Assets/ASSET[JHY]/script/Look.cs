using UnityEngine;

public class Look : MonoBehaviour
{
    public Transform target; // 바라볼 대상 오브젝트의 Transform

    void Update()
    {
        if (target != null)
        {
            // 대상의 위치를 향해 바라보기 (Y축 이외의 축은 고정)
            Vector3 directionToTarget = target.position - transform.position;
            directionToTarget.y = 0; // Y 성분을 0으로 설정하여 Y축 회전을 고정

            // 대상을 Y축 이외의 축을 고정하여 바라보기 위한 회전 생성
            Quaternion rotation = Quaternion.LookRotation(directionToTarget, Vector3.up);

            // 해당 회전을 오브젝트에 적용
            transform.rotation = rotation;
        }
    }
}
