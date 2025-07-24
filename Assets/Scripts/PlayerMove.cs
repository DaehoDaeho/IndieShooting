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
        // Ű������ �����¿� Ű�� ������ �� �Է� �� ��������.
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        // �̵��� ���� ���.
        Vector3 dir = new Vector3(h, v, 0);

        // ����� �������� �÷��̾ �̵����� ��ġ�� ����.
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
