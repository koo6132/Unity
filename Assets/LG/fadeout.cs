using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fadeout : MonoBehaviour
{
    private CanvasGroup cg;
    public float fadeTime = 1f; // OS E
    float accumTime = 0f;
    private Coroutine fadeCor;

    private void Awake()
    {
        cg = gameObject.GetComponent<CanvasGroup>();
        StartFadeIn();
    }
    // Start is called before the first frame update
    
    void StartFadeIn()
    {
        if(fadeCor != null)
        {
            StopAllCoroutines();
            fadeCor = null;
        }
        fadeCor = StartCoroutine(FadeIn());
    }
     private IEnumerator FadeIn()
    {
        yield return new WaitForSeconds(0.2f);
        accumTime = 0f;
        while (accumTime < fadeTime)
        {
            cg.alpha = Mathf.Lerp(0f, 1f, accumTime / fadeTime);
            yield return 0;
            accumTime += Time.deltaTime;
        }
        cg.alpha = 1f;
        StartCoroutine(FadeOut());
    }
    
    private IEnumerator FadeOut()
    {
        yield return new WaitForSeconds(5.0f);
        accumTime = 0f;
        while (accumTime < fadeTime)
        {
            cg.alpha = Mathf.Lerp(1f, 0f, accumTime / fadeTime);
            yield return 0;
            accumTime += Time.deltaTime
;        }
        cg.alpha = 0f;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
