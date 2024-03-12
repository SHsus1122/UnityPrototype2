using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private Vector3 spawnPos;   // 스폰 시킬 위치 변수
    private float delayCount;   // 발사 시간 체크용 변수
    private float maxCount = 1; // 발사 딜레이를 위한 변수

    // Update is called once per frame
    void Update()
    {
        // maxCount가 1초가 아니면 delayCount를 증가시키지 않습니다.
        // 즉, 발사 딜레이인 maxCount 를 기준으로 증가시킬지 말지 결정합니다.
        if (delayCount <= maxCount)
        {
            delayCount += Time.deltaTime;
        }

        // On spacebar press, send dog
        // 강아지 호출 함수
        // space 를 눌렀을 때, delayCount 가 maxCount 보다 큰 경우 즉, 호출 가능할 경우를 조건으로 겁니다.
        if (Input.GetKeyDown(KeyCode.Space) && delayCount >= maxCount)
        {
            spawnPos = new Vector3(transform.position.x - 2, transform.position.y, transform.position.z);

            Instantiate(dogPrefab, spawnPos, dogPrefab.transform.rotation);

            // 강아지를 한 번 호출했으면 이제 delayCount 를 초기화 시켜 줍니다.
            delayCount = 0;
        }
    }
}
