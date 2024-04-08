using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // 해당 스크립트를 사용중인 경우에는 아래의 로직을 수행합니다.
    // 트리거 이벤트 발생시 해당 게임 오브젝트의 경우에는 Destroy 로 완전 삭제합니다.
    // 하지만 그게 아닌 다른 오브젝트의 경우에는 해당 오브젝트를 비활성화 시킵니다.
    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        // Instead of destroying the projectile when it collides with an animal
        //Destroy(other.gameObject); 

        // Just deactivate the food and destroy the animal
        other.gameObject.SetActive(false);
    }

}
