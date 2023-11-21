using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class monster : MonoBehaviour
{
    // 변수 선언
    public GameObject onOffObject; // 활성화/비활성화할 객체
    public float Speed = 2f; // 몬스터의 기본 이동 속도
    private Transform TR; // 몬스터의 트랜스폼

    private Transform MOM;
    private NavMeshAgent agent; // 몬스터의 NavMeshAgent
    private bool aaa = false;




    // Start 함수는 첫 번째 프레임 업데이트 전에 호출됩니다.
    void Start()
    {
        TR = GetComponent<Transform>(); // 자기 자신의 Transform 컴포넌트 가져오기       
        agent = GetComponent<NavMeshAgent>(); // NavMeshAgent 컴포넌트 가져오기


    }





    // Update 함수는 매 프레임마다 호출됩니다.
    void Update()
    {
        MOM = GameObject.FindWithTag("AAA").GetComponent<Transform>();


        agent.destination = MOM.position;

    }

    // onTriggerEnter 이벤트에 대한 활성화 함수







    // onTriggerExit 이벤트에 대한 비활성화 함수
}
