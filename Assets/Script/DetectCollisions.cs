using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 유니티 기본 제공 함수를 사용합니다.
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);        // 자기 자신을 삭제
        Destroy(other.gameObject);  // 충돌한 객체를 삭제
    }
}
