
using UnityEngine;

public class SpawningManager : MonoBehaviour
{
    public GameObject luigiPrefab;
    public GameObject warioPrefab;
    public GameObject marioPrefab;
    public GameObject yoshiPrefab;

    private float minX = -6.4f;
    private float maxX = 6.52f;
    private float minY = -1.98f;
    private float maxY = 3.64f;

    void Start()
    {
        // Spawn a single Luigi
        SpawnObject(luigiPrefab, 1);

        // Spawn between 10-20 Warios
        SpawnObject(warioPrefab, Random.Range(10, 21));

        // Spawn between 10-20 Marios
        SpawnObject(marioPrefab, Random.Range(10, 21));

        // Spawn between 10-20 Yoshis
        SpawnObject(yoshiPrefab, Random.Range(10, 21));
    }

    void SpawnObject(GameObject prefab, int count)
    {
        for (int i = 0; i < count; i++)
        {
            float randomX = Random.Range(minX, maxX);
            float randomY = Random.Range(minY, maxY);
            Vector2 spawnPosition = new Vector2(randomX, randomY);
            Instantiate(prefab, spawnPosition, Quaternion.identity);
        }
    }
}
