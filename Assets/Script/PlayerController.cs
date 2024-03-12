using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//플레이어 움직임 및 조작을 위한 클래스입니다.
public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 10.0f;

    // 투사체 변수 생성
    public GameObject projectilePrefab;

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

        // 키 입력값 가져오기
        //  - Input.GetKey     : 키가 눌렸을 때
        //  - Input.GetKeyDown : 키가 눌린 상태일 때
        //  - Input.GetKeyUp   : 키에서 손가락을 땔 때, true 를 반환 합니다.
        // 입력값의 종류는 KeyCode 를 사용해서 받아올 수 있습니다.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Launch a projectile form the player
            // 인스턴스 생성 즉, projectilePrefab 의 복사본을 생성합니다.
            // 인자 설명
            //  - 원본 객체, 좌표값, 회전값
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
