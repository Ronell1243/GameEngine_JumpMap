using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShooter : MonoBehaviour
{
    public GameObject BulletPrefab;
    public Transform firePoint;
    public float bulletSpeed = 20f;
    public float fireCooldown = 0.2f;   //연속 클릭 간격

    float lastFireTime = -999f;

    public void OnAttack(InputValue value)
    {
        if (Time.timeScale == 0f) return;   //게임 오버면 무시
        if (Time.time < lastFireTime + fireCooldown) return;
        lastFireTime = Time.time;

        GameObject bullet = Instantiate(BulletPrefab,
            firePoint.position, firePoint.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.linearVelocity = firePoint.forward * bulletSpeed;
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
