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
    
    public float speed = 5f; // �̵� �ӵ��� �����ϴ� ����

    void Update()
    {
        // Ű���� �Է� ����
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // �̵� ���� ���
        Vector3 movementDirection = new Vector3(horizontalInput, verticalInput,0 );

        // ������ ���͸� ����ȭ�Ͽ� ���̰� 1�� �ǵ��� ��
        movementDirection.Normalize();

        // ������ �̵�
        transform.Translate(movementDirection * speed * Time.deltaTime);
    }

}
