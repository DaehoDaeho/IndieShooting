using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 2.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // �� �����Ӹ��� ȣ��Ǵ� �Լ�
    void Update()
    {
        // ��ġ ����.
        transform.position += Vector3.down * speed * Time.deltaTime;

        // ���� ��ġ ���Ϸ� ���������� ������Ʈ �ı�.
        if(transform.position.y < -7.0f)
        {
            Destroy(gameObject);
        }
    }
}
