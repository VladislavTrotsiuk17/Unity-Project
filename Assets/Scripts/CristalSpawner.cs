using UnityEngine;

public class CristalSpawner: MonoBehaviour
{
    [SerializeField] private GameObject cristalPrefab;
    [SerializeField] private float comparisonChance = 0.1f;

    private void Start()
    {
        
        float randomValue = Random.Range(0f, 1f);

        if (randomValue <= comparisonChance)
        {
            
            Instantiate(cristalPrefab, new Vector3(transform.position.x, 1.45f ,transform.position.z), transform.rotation);
        }
    }
}
