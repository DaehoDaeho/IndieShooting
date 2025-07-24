using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] enemyPrefab;
    public float spawnDelay = 1.0f;
    float timer = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // = ���Կ�����, += ����������
        timer += Time.deltaTime; // timer ������ Time.deltaTime ���� �ջ��ϰڴ�.
        if(timer > spawnDelay)
        {
            int index = Random.Range(0, 2);
            // ������ ���� ���� ������ �߻��ϴ� �Լ�.
            // x ��ǥ�� �����ϰ� �����ϱ� ���� ���.
            float x = Random.Range(-2.5f, 2.5f);
            Instantiate(enemyPrefab[index], new Vector3(x, 7.0f, 0.0f), Quaternion.identity);
            timer = 0.0f;
        }
    }
}
