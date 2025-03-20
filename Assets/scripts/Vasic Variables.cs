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
    public int JumpForce = 5;
    public Rigidbody rb;
    private bool isGrounded;
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
            Debug.Log("���� ��� : " + gold);
        }

        Move();

    }

    private void Move()
    {
        float MoveX = Input.GetAxis("Horizontal");
        float MoveZ = Input.GetAxis("Vertical");

        Vector3 Direction = new Vector3(MoveX, 0, MoveZ).normalized;

        rb.MovePosition(transform.position + Direction * Speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {
            rb.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
        }

        
    }

    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
    }
    private void OnCollisionExit(Collision collision)
    {
        isGrounded = false;

    }
}
