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
            Ray ray = new Ray(transform.position, transform.forward); //�߻��� ray�� ������, ��������(���� ī�޶󿡼� ���콺 Ŀ�� �������� �߻�)
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit)) //raycast�� ��ȯ���� bool��, ray�� �¾Ҵٸ� true�� ��ȯ
            {
                Destroy(hit.collider.gameObject);
            }
    }
}
