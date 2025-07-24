using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 키보드의 상하좌우 키가 눌렸을 때 입력 값 가져오기.
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        // 이동할 방향 계산.
        Vector3 dir = new Vector3(h, v, 0);

        // 계산한 방향으로 플레이어를 이동시켜 위치를 갱신.
        transform.position += dir.normalized * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Debug.Log("Player is dead");
            GameManager.Instance.ShowGameOver();
            gameObject.SetActive(false);
        }
    }
}
