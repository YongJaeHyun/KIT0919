using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform avatar;  // 아바타(Transform)을 연결할 변수
    public Vector3 offset = new Vector3(0.0f, 2.0f, -5.0f);  // 카메라의 상대적인 위치

    public float smoothSpeed = 0.125f;  // 카메라 이동을 부드럽게 하기 위한 변수

    void LateUpdate()
    {
        if (avatar == null)
            return;

        // 아바타의 위치에 상대적인 카메라의 위치를 계산
        Vector3 desiredPosition = avatar.position + offset;

        // 카메라를 부드럽게 이동시킴
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        // 카메라가 아바타를 바라보게 함
        transform.LookAt(avatar);
    }
}