using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -1;
    private float spawnLimitXRight = 8;
    private float spawnPosY = 10;

    private float startDelay = 1.0f;
    private float spawnInterval = 3.0f;
    private int ballIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        // 공이 스폰되는 시간을 게임 시작시 랜덤하게 지정합니다. 3~5 사이의 값
        spawnInterval = Random.Range(3, 6);
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, -2);
        ballIndex = Random.Range(0, ballPrefabs.Length);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);
    }

}
