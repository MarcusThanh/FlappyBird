using UnityEngine;

public class PillarSpawner : MonoBehaviour
{
    public GameObject pipePrefab; 
    public float spawnRate = 1.7f;  // tgian spawn
    public float minY = -2f;      // Độ cao thấp nhất
    public float maxY = 2f;       // Độ cao cao nhất

    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnRate)
        {
            SpawnPipe();
            timer = 0f;
        }
    }

    void SpawnPipe()
    {
        // độ cao
        float randomY = Random.Range(minY, maxY);

        // vị trí sinh ra
        Vector3 spawnPos = new Vector3(transform.position.x, randomY, 0);

        //
        Instantiate(pipePrefab, spawnPos, Quaternion.identity);
    }
}