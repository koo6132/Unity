using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStage : MonoBehaviour
{
    public static PlayerStage instance;

    public int playerStage;


    void Awake()
    {
        instance = this;
    }
}

