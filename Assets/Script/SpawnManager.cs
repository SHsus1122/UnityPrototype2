﻿using System.Collections;
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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // S 키를 눌러서 배열안의 녀석들 중 에디터에서 고른 녀석을 출력
        if (Input.GetKeyDown(KeyCode.S))
        {
            int animalIndex = Random.Range(0, animalPrefabs.Length);        // 이 프로젝트 상에서는 0 ~ 2 범위의 랜덤 숫자
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);   // 생성 동물, 위치 랜덤으로 변경

            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
        }
    }
}
