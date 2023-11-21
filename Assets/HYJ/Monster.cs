using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Scripting;

public class Monster : MonoBehaviour
{
    // 변수 선언
    public GameObject onOffObject; // 활성화/비활성화할 객체
    public float Speed = 2.5f; // 몬스터의 기본 이동 속도
    private Transform TR; // 몬스터의 트랜스폼
    private Transform PlayerTR; // 플레이어의 트랜스폼
    private Transform MOM;
    private NavMeshAgent agent; // 몬스터의 NavMeshAgent
    public List<trigger> trList; // 트리거 클래스
    public List<ConcealTr> conoealTr; //인식 안하게 하는거
    public button buttonTr;
    public trtr trigrrer;
    private bool aaa = false;
    public float MonsterStop = 2; //몬스터 정지시간
    

   

    // Start 함수는 첫 번째 프레임 업데이트 전에 호출됩니다.
    void Start()
    {
        
        trList.ForEach(tr => {
            tr.onTriggerEnterEvent += ActiveObj; // 트리거에 진입할 때 활성화 이벤트에 대한 핸들러 추가
            
            tr.onTriggerExitEvent += InactiveObj; // 트리거에서 나올 때 비활성화 이벤트에 대한 핸들러 추가
        });

        conoealTr.ForEach(tr =>
        {
            tr.onTriggerEnterConceal += ActiveConceal;
        });

        buttonTr.onTriggerButton += ActiveObj;


        // 트리거 이벤트에 대한 이벤트 핸들러 설정

        trigrrer.onTriggerTimeEnterEvent += TriggerTime;


        // 필요한 컴포넌트 및 변수 초기화

        TR = GetComponent<Transform>(); // 자기 자신의 Transform 컴포넌트 가져오기
        PlayerTR = GameObject.FindWithTag("Player").GetComponent<Transform>(); // "Player" 태그를 가진 게임 오브젝트의 Transform 가져오기
        agent = GetComponent<NavMeshAgent>(); // NavMeshAgent 컴포넌트 가져오기

        
    }

    private void Tr_onTriggerStayEvent()
    {
        throw new NotImplementedException();
    }



    // Update 함수는 매 프레임마다 호출됩니다.
    void Update()
    {
        MOM = GameObject.FindWithTag("Temporary").GetComponent<Transform>();
       
        // 에이전트의 속도 설정
        agent.speed = Speed; // 몬스터의 이동 속도 설정
        if (aaa == true)
        {
            agent.destination = PlayerTR.position; // 플레이어의 위치를 목적지로 설정하여 플레이어를 추적합니다.
        }
        else
        {
            agent.destination = MOM.position;
        }
    }
    
    // onTriggerEnter 이벤트에 대한 활성화 함수
    public void ActiveObj()
    {
        Speed += 0.4f ; // 트리거 진입시 몬스터의 이동 속도를 1f로 변경
        Debug.Log("쫒아옴 속도 = "+Speed); // 디버그 메시지 출력
        aaa =true;
    }

    public void ActiveConceal() 
    {
        
        Debug.Log("돌아감");
        aaa = false;
    }




    // onTriggerExit 이벤트에 대한 비활성화 함수
    public void InactiveObj()
    {
        // 여기에 트리거에서 나올 때 비활성화할 동작 추가
    }

    public void TriggerTime()
    {
        Debug.Log("성공");
        StartCoroutine(StopForSeconds(MonsterStop)); // 5초간 정지하는 코루틴을 실행
    }
    private IEnumerator StopForSeconds(float seconds)
    { 
        agent.isStopped = true;
        yield return new WaitForSecondsRealtime(seconds); // 지정된 시간 동안 대기합니다.
        agent.isStopped = false;
    }
}

