using System.Collections;
using UnityEngine;

public class BlinkingLight : MonoBehaviour {
    public float blinkInterval = 0.5f; // �����̴� ���� (��)
    private Light pointLight; // ������ PointLight ������Ʈ

    private void Start() {
        pointLight = GetComponent<Light>();

        // �����̱� ����
        StartCoroutine(BlinkLight());
    }

    private IEnumerator BlinkLight() {
        while (true) {
            // PointLight�� ���� �մϴ�.
            pointLight.enabled = !pointLight.enabled;

            // blinkInterval ���ݸ�ŭ ����մϴ�.
            yield return new WaitForSeconds(blinkInterval);
        }
    }
}
