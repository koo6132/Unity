using System.Collections;
using UnityEngine;

public class TrLight : MonoBehaviour
{
    public float blinkInterval = 0.5f; // 깜빡이는 간격 (초)
   
    private Light pointLight; // 깜빡일 PointLight 컴포넌트
    public GameObject a;

    private void Start()
    {
        pointLight = GetComponent<Light>();

        // 깜빡이기 시작
        StartCoroutine(BlinkLight());
    }

    private void Update()
    {
        
    }

    private IEnumerator BlinkLight()
    {
        while (true)
        {
            
            // PointLight를 껐다 켭니다.
            pointLight.enabled = !pointLight.enabled;
            // blinkInterval 간격만큼 대기합니다.

            // a를 껐다 켭니다.
            a.SetActive(!a.activeSelf);

            // blinkInterval 간격만큼 대기합니다.
            yield return new WaitForSeconds(blinkInterval);

        }
    }
}
