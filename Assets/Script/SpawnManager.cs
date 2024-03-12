using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 동물을 스폰시키기 위해서 사용되는 스크립트입니다.
public class SpawnManager : MonoBehaviour
{
    // 여러 동물들을 스폰시키기 위해서 배열로 선언
    public GameObject[] animalPrefabs;
    //public int animalIndex;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    private float startDelay= 2;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        // 호출할 메서드를 사용해 특정 시점에 해당 메서드의 호출을 시작하고 시간 경과에 따라 원하는 속도로 호출을 반복합니다.
        // 인자 설명 : 호출할 함수명, 시작 시간, 반복 주기
        // 주의할 점으로 함수명은 대소문자까지 정확히 일치해야 합니다.
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);        // 이 프로젝트 상에서는 0 ~ 2 범위의 랜덤 숫자
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);   // 생성 동물, 위치 랜덤으로 변경

        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
