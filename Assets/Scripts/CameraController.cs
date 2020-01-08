using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 3인칭 시점 카메라 Controller
// Camera가 Player와 offset을 유지하는 Controller (자식계층으로 만들면 position 외의 rotation, scale도 동시에 움직여버림.) 
public class CameraController : MonoBehaviour
{
    public GameObject player;

    private Vector3 offset;

    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // LateUpdate is called once per frame & Update 이후 실행됨.
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
