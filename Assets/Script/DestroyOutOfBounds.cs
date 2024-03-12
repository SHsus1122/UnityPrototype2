using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 일정 거리 이상 벗어났을 때 오브젝트 삭제를 위한 스크립트입니다.
// 삭제 되지 않은채로 계속 남아있으면 메모리 관리에 매우 치명적이기에 이를 관리하기 위한 스크립트입니다.
public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            // Destroy 는 게임 오브젝트 뿐만 아니라 컴포넌트와 에셋도 제거 가능합니다.
            // gameObject 는 자기 자신 즉, 현재 게임 오브젝트를 의미합니다.
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
        }
    }
}
