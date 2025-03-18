using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VasicVariables : MonoBehaviour
{
    public int gold = 0;
    public float Hp = 100.0f;
    public string playName = "홍길동";
    public bool isAlive = true;
    public int Speed = 3;
    


    // Start is called before the first frame update
    void Start()
    {
    if (gold > 50)
        {
            Debug.Log("아이템을 구매할 수 있습니다");
        }

    else if (gold == 40)
        {
            Debug.Log("골드 40원을 보유중입니다. 10 골드만큼만 더 일하면 포르쉐를 살 수 있어요!");
        }

    else
        {
            Debug.Log("골드가 부족합니다");
        }

    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            gold = gold++; //10씩 증가
            Debug.Log("현재 골드 : " +  gold);
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
