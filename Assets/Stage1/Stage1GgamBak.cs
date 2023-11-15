using System.Collections;
using UnityEngine;

public class BlinkingLight : MonoBehaviour {
    public float blinkInterval = 0.5f; // ±ôºıÀÌ´Â °£°İ (ÃÊ)
    private Light pointLight; // ±ôºıÀÏ PointLight ÄÄÆ÷³ÍÆ®

    private void Start() {
        pointLight = GetComponent<Light>();

        // ±ôºıÀÌ±â ½ÃÀÛ
        StartCoroutine(BlinkLight());
    }

    private IEnumerator BlinkLight() {
        while (true) {
            // PointLight¸¦ ²°´Ù ÄÕ´Ï´Ù.
            pointLight.enabled = !pointLight.enabled;

            // blinkInterval °£°İ¸¸Å­ ´ë±âÇÕ´Ï´Ù.
            yield return new WaitForSeconds(blinkInterval);
        }
    }
}
