using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class monster : MonoBehaviour
{
    // ���� ����
    public GameObject onOffObject; // Ȱ��ȭ/��Ȱ��ȭ�� ��ü
    public float Speed = 2f; // ������ �⺻ �̵� �ӵ�
    private Transform TR; // ������ Ʈ������

    private Transform MOM;
    private NavMeshAgent agent; // ������ NavMeshAgent
    private bool aaa = false;




    // Start �Լ��� ù ��° ������ ������Ʈ ���� ȣ��˴ϴ�.
    void Start()
    {
        TR = GetComponent<Transform>(); // �ڱ� �ڽ��� Transform ������Ʈ ��������       
        agent = GetComponent<NavMeshAgent>(); // NavMeshAgent ������Ʈ ��������


    }





    // Update �Լ��� �� �����Ӹ��� ȣ��˴ϴ�.
    void Update()
    {
        MOM = GameObject.FindWithTag("AAA").GetComponent<Transform>();


        agent.destination = MOM.position;

    }

    // onTriggerEnter �̺�Ʈ�� ���� Ȱ��ȭ �Լ�







    // onTriggerExit �̺�Ʈ�� ���� ��Ȱ��ȭ �Լ�
}
