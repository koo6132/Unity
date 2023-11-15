using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Scripting;

public class Monster : MonoBehaviour
{
    // ���� ����
    public GameObject onOffObject; // Ȱ��ȭ/��Ȱ��ȭ�� ��ü
    public float Speed; // ������ �⺻ �̵� �ӵ�
    private Transform TR; // ������ Ʈ������
    private Transform PlayerTR; // �÷��̾��� Ʈ������
    private Transform MOM;
    private NavMeshAgent agent; // ������ NavMeshAgent
    public List<trigger> trList; // Ʈ���� Ŭ����
    public List<ConcealTr> conoealTr; //�ν� ���ϰ� �ϴ°�
    public button buttonTr;
    public trtr trigrrer;
    private bool aaa = false;
    public float MonsterStop = 2; //���� �����ð�
    public float SpeedS = 1.5f;

   

    // Start �Լ��� ù ��° ������ ������Ʈ ���� ȣ��˴ϴ�.
    void Start()
    {
        Speed = SpeedS;
        trList.ForEach(tr => {
            tr.onTriggerEnterEvent += ActiveObj; // Ʈ���ſ� ������ �� Ȱ��ȭ �̺�Ʈ�� ���� �ڵ鷯 �߰�
            
            tr.onTriggerExitEvent += InactiveObj; // Ʈ���ſ��� ���� �� ��Ȱ��ȭ �̺�Ʈ�� ���� �ڵ鷯 �߰�
        });

        conoealTr.ForEach(tr =>
        {
            tr.onTriggerEnterConceal += ActiveConceal;
        });

        buttonTr.onTriggerButton += ActiveObj;


        // Ʈ���� �̺�Ʈ�� ���� �̺�Ʈ �ڵ鷯 ����

        trigrrer.onTriggerTimeEnterEvent += TriggerTime;


        // �ʿ��� ������Ʈ �� ���� �ʱ�ȭ

        TR = GetComponent<Transform>(); // �ڱ� �ڽ��� Transform ������Ʈ ��������
        PlayerTR = GameObject.FindWithTag("Player").GetComponent<Transform>(); // "Player" �±׸� ���� ���� ������Ʈ�� Transform ��������
        agent = GetComponent<NavMeshAgent>(); // NavMeshAgent ������Ʈ ��������

        
    }

    private void Tr_onTriggerStayEvent()
    {
        throw new NotImplementedException();
    }



    // Update �Լ��� �� �����Ӹ��� ȣ��˴ϴ�.
    void Update()
    {
        MOM = GameObject.FindWithTag("Temporary").GetComponent<Transform>();
       
        // ������Ʈ�� �ӵ� ����
        agent.speed = Speed; // ������ �̵� �ӵ� ����
        if (aaa == true)
        {
            agent.destination = PlayerTR.position; // �÷��̾��� ��ġ�� �������� �����Ͽ� �÷��̾ �����մϴ�.
        }
        else
        {
            agent.destination = MOM.position;
        }
    }
    
    // onTriggerEnter �̺�Ʈ�� ���� Ȱ��ȭ �Լ�
    public void ActiveObj()
    {
        Speed += 0.4f ; // Ʈ���� ���Խ� ������ �̵� �ӵ��� 1f�� ����
        Debug.Log("�i�ƿ� �ӵ� = "+Speed); // ����� �޽��� ���
        aaa =true;
    }

    public void ActiveConceal() 
    {
        Speed = SpeedS;
        Debug.Log("���ư�");
        aaa = false;
    }




    // onTriggerExit �̺�Ʈ�� ���� ��Ȱ��ȭ �Լ�
    public void InactiveObj()
    {
        // ���⿡ Ʈ���ſ��� ���� �� ��Ȱ��ȭ�� ���� �߰�
    }

    public void TriggerTime()
    {
        Debug.Log("����");
        StartCoroutine(StopForSeconds(MonsterStop)); // 5�ʰ� �����ϴ� �ڷ�ƾ�� ����
    }
    private IEnumerator StopForSeconds(float seconds)
    { 
        agent.isStopped = true;
        yield return new WaitForSecondsRealtime(seconds); // ������ �ð� ���� ����մϴ�.
        agent.isStopped = false;
    }
}

