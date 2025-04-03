using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastShooter : MonoBehaviour
{
   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            ShootRay();
        }

        
    }

    private void ShootRay()
    {
            Ray ray = new Ray(transform.position, transform.forward); //발사할 ray의 시작점, 방향지정(메인 카메라에서 마우스 커서 방향으로 발사)
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit)) //raycast의 반환형은 bool로, ray를 맞았다면 true로 반환
            {
                Destroy(hit.collider.gameObject);
            }
    }
}
