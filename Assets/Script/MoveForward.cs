using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 동물 또는 투사체(피자)에 움직임을 구현해주는 스크립트입니다.
public class MoveForward : MonoBehaviour
{
    public float speed = 40.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 발사체에 움직임을 구현해줍니다.(앞으로 시간당 speed 만큼 이동)
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
