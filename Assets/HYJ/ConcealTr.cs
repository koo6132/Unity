using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConcealTr : MonoBehaviour
{
    public event Action onTriggerEnterConceal;
    // Start is called before the first frame update

    private void OnCollisionEnter(Collision collision)
    {
        onTriggerEnterConceal?.Invoke();
    }
}
