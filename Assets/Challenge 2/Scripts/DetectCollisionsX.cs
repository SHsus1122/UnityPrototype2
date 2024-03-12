using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{
    public GameObject animalObj;

    private void OnTriggerEnter(Collider other)
    {
        // other.gameObject == animalObj 비교를 시도했습니다. animalObj 는 유니티 에디터에서 지정
        // 하지만, 이렇게 하면 인스턴스 끼리의 비교이기 때문에 다른 스크립트에서 생성된 것 끼리 비교하는
        // 지금 같은 경우에는 무조건 거짓이기 때문에 if 문에 걸리지 않았습니다.
        // 그래서 스폰시키는 Dog 프리팹의 Tag 와 비교해서 강아지일 Dog 일 경우에만 삭제하게 조건을 걸었습니다.
        if (other.CompareTag("Dog"))
        {
            Destroy(gameObject);
        }
    }
}
