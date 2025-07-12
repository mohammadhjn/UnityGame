using UnityEngine;

public class randomdrop : MonoBehaviour
{
    public GameObject dropPrefab;
    public float spawnInterval = 0.5f;
    public float spawnRangeX = 8f;
    public float spawnHeight = 5f;

    private void Start()
    {
        InvokeRepeating("SpawnDrop", 0f, spawnInterval);
    }

    void SpawnDrop()
    {
        float randomX = Random.Range(-spawnRangeX, spawnRangeX);
        Vector3 spawnPosition = new Vector3(randomX, spawnHeight, 0f);
        Instantiate(dropPrefab, spawnPosition, Quaternion.identity);
    }
}
