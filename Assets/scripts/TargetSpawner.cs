using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawner : MonoBehaviour
{
    public GameObject TargetPrefabs;
    public float generateTime = 3f;
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;            //timer 변수에서 deltaTime을 빼서 지난 시간 측정

        if (timer < 0)
        {
            timer -= generateTime;          //timer에 재생성 시간을 입력함

            float xPosition = Random.Range(-10f, 10f);
            Vector3 newPosition = new Vector3(xPosition, 0, 0);
            Instantiate(TargetPrefabs, newPosition, Quaternion.identity);   //과녁 프리팹을 newPosition 위치에 생성함
        }

    }
}
