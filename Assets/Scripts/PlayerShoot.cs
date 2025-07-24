using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject bulletPrefab; // 총알 Prefab
    public Transform firePoint; // 총알 발사 위치.
    public float fireDelay = 0.2f;  // 발사 딜레이 시간.
    private float lastFire = 0.0f;  // 마지막으로 발사한 시간.

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 스페이스 키가 눌린 상태고, 딜레이 시간이 초과됐으면...
        if(Input.GetKey(KeyCode.Space) && Time.time > lastFire + fireDelay)
        {
            // 총알 프리팹을 불러와서 시작 위치에 배치한다.
            Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
            //Instantiate(Resources.Load("Bullet"), firePoint.position, Quaternion.identity);
            lastFire = Time.time;
        }
    }
}
