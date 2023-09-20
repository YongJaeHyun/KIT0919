using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvartarController : MonoBehaviour
{
    public float moveSpeed = 5.0f;

    void Update()
    {
        // 수평축과 수직축 입력을 받아옴
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // 이동 방향 설정
        Vector3 moveDirection = new Vector3(horizontal, 0.0f, vertical);
        moveDirection.Normalize(); // 벡터를 정규화하여 길이를 1로 만듦

        // 움직임 적용
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }
}