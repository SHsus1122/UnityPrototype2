using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        // z 수치가 30 이상인 즉, 위 방향으로 발사체에 해당하는 오브젝트는 비활성화를 합니다.
        if (transform.position.z > topBound)
        {
            // Instead of destroying the projectile when it leaves the screen
            //Destroy(gameObject);

            // Just deactivate it
            gameObject.SetActive(false);
        }
        else if (transform.position.z < lowerBound)
        {
            // 이 경우에는 z 의 수치가 -10 이하 즉, 아래 방향으로 움직이는 오브젝트는 파괴합니다.
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }

    }
}
