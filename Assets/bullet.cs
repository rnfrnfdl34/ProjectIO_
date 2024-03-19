using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public GameObject bulletPrefab; // �߻��� �Ѿ� ������
    public Transform firePoint; // �Ѿ��� �߻�� ��ġ
    public float bulletSpeed = 10f; // �Ѿ��� �ӵ�

    void Update()
    {
        // Ű �Է��� �����Ͽ� �Ѿ� �߻�
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShootBullet();
        }
    }

    void ShootBullet()
    {
        // �Ѿ� �������� �����Ͽ� ����
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        // �Ѿ˿� Rigidbody ������Ʈ�� �߰��Ͽ� ����ȿ�� ����
        Rigidbody bulletRigidbody = bullet.GetComponent<Rigidbody>();

        // �Ѿ��� �߻� �������� �̵�
        bulletRigidbody.velocity = firePoint.forward * bulletSpeed;
    }
}
