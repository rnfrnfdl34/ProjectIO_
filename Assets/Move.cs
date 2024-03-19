using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    
    public float speed = 5f; // 이동 속도를 조절하는 변수

    void Update()
    {
        // 키보드 입력 감지
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // 이동 방향 계산
        Vector3 movementDirection = new Vector3(horizontalInput, verticalInput,0 );

        // 움직임 벡터를 정규화하여 길이가 1이 되도록 함
        movementDirection.Normalize();

        // 실제로 이동
        transform.Translate(movementDirection * speed * Time.deltaTime);
    }

}
