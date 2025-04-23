using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{
    [SerializeField] Vector3 direction;

    [SerializeField] float speed = 5.0f;

    void Update()
    {
        direction.x = Input.GetAxis("Horizontal");
        direction.z = Input.GetAxis("Vertical");

        direction.Normalize();

        // Time.deltaTime
        // ������ �������� �Ϸ��ϴµ� ����� �ð��� �� ������ ��ȯ�ϴ� �ð��Դϴ�.
        transform.position = transform.position + direction * speed * Time.deltaTime;

    }
}
