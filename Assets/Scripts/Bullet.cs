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

        // �Ѿ��� y ��ġ�� 7���� ũ��.
        if(transform.position.y > 7.0f)
        {
            // ���� ������Ʈ�� �ı��Ѵ�.
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
