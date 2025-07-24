using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject bulletPrefab; // �Ѿ� Prefab
    public Transform firePoint; // �Ѿ� �߻� ��ġ.
    public float fireDelay = 0.2f;  // �߻� ������ �ð�.
    private float lastFire = 0.0f;  // ���������� �߻��� �ð�.

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // �����̽� Ű�� ���� ���°�, ������ �ð��� �ʰ�������...
        if(Input.GetKey(KeyCode.Space) && Time.time > lastFire + fireDelay)
        {
            // �Ѿ� �������� �ҷ��ͼ� ���� ��ġ�� ��ġ�Ѵ�.
            Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
            //Instantiate(Resources.Load("Bullet"), firePoint.position, Quaternion.identity);
            lastFire = Time.time;
        }
    }
}
