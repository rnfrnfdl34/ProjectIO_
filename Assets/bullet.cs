using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public GameObject bulletPrefab; // 발사할 총알 프리팹
    public Transform firePoint; // 총알이 발사될 위치
    public float bulletSpeed = 10f; // 총알의 속도

    void Update()
    {
        // 키 입력을 감지하여 총알 발사
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShootBullet();
        }
    }

    void ShootBullet()
    {
        // 총알 프리팹을 복제하여 생성
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        // 총알에 Rigidbody 컴포넌트를 추가하여 물리효과 적용
        Rigidbody bulletRigidbody = bullet.GetComponent<Rigidbody>();

        // 총알을 발사 방향으로 이동
        bulletRigidbody.velocity = firePoint.forward * bulletSpeed;
    }
}
