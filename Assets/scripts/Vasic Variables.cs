using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VasicVariables : MonoBehaviour
{
    public int gold = 0;
    public float Hp = 100.0f;
    public string playName = "ȫ�浿";
    public bool isAlive = true;
    public int Speed = 3;
    


    // Start is called before the first frame update
    void Start()
    {
    if (gold > 50)
        {
            Debug.Log("�������� ������ �� �ֽ��ϴ�");
        }

    else if (gold == 40)
        {
            Debug.Log("��� 40���� �������Դϴ�. 10 ��常ŭ�� �� ���ϸ� �������� �� �� �־��!");
        }

    else
        {
            Debug.Log("��尡 �����մϴ�");
        }

    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            gold = gold++; //10�� ����
            Debug.Log("���� ��� : " +  gold);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Speed * Time.deltaTime);
        }
        
    }
}
