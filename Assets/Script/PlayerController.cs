using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 10.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // 좌우 거리 제한
        // 일정 범위를 벗어나면 다시 지정해준 범위로 돌아가게 하는 방식입니다.
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        { 
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        // 입력을 Time.deltaTime 를 사용해서 프레임 단위가 아닌 시간 단위로 받습니다.
        // 이렇게 해야 컴퓨터 사양에 상관없이 모두가 일정한 속도로 움직에 됩니다.
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
    }
}
