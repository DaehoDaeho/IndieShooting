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
        // = 대입연산자, += 증감연산자
        timer += Time.deltaTime; // timer 변수에 Time.deltaTime 값을 합산하겠다.
        if(timer > spawnDelay)
        {
            int index = Random.Range(0, 2);
            // 지정한 범위 내의 난수를 발생하는 함수.
            // x 좌표를 랜덤하게 지정하기 위해 사용.
            float x = Random.Range(-2.5f, 2.5f);
            Instantiate(enemyPrefab[index], new Vector3(x, 7.0f, 0.0f), Quaternion.identity);
            timer = 0.0f;
        }
    }
}
