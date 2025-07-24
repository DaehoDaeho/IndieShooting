using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.up * speed * Time.deltaTime;

        // 총알의 y 위치가 7보다 크면.
        if(transform.position.y > 7.0f)
        {
            // 게임 오브젝트를 파괴한다.
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            GameManager.Instance.AddScore(10);
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
