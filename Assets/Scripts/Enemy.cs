using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 2.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // 매 프레임마다 호출되는 함수
    void Update()
    {
        // 위치 갱신.
        transform.position += Vector3.down * speed * Time.deltaTime;

        // 일정 위치 이하로 내려갔으면 오브젝트 파괴.
        if(transform.position.y < -7.0f)
        {
            Destroy(gameObject);
        }
    }
}
