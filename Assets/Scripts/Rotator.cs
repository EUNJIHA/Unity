using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Pick Up 의 rotation을 지속적으로 
public class Rotator : MonoBehaviour
{

    // 물리 적용 안하므로 그냥 Update.
    void Update()
    {
        // Time.deltaTime 은 프레임 속도와 무관하기 위함.
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
        /*transform.Rotate(new Vector3(45, 45, 45) * Time.deltaTime);*/
    }
}
