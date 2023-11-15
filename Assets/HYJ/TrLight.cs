using System.Collections;
using UnityEngine;

public class TrLight : MonoBehaviour
{
    public float blinkInterval = 0.5f; // �����̴� ���� (��)
   
    private Light pointLight; // ������ PointLight ������Ʈ
    public GameObject a;

    private void Start()
    {
        pointLight = GetComponent<Light>();

        // �����̱� ����
        StartCoroutine(BlinkLight());
    }

    private void Update()
    {
        
    }

    private IEnumerator BlinkLight()
    {
        while (true)
        {
            
            // PointLight�� ���� �մϴ�.
            pointLight.enabled = !pointLight.enabled;
            // blinkInterval ���ݸ�ŭ ����մϴ�.

            // a�� ���� �մϴ�.
            a.SetActive(!a.activeSelf);

            // blinkInterval ���ݸ�ŭ ����մϴ�.
            yield return new WaitForSeconds(blinkInterval);

        }
    }
}
