using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] private GameObject boxPrefab;
    [SerializeField] private GameObject ball;
    [SerializeField] private int numberOfCubes = 30;
    [SerializeField] private List<GameObject> prefabList;
    public float timeInterval = 0.3f;
    public List<Vector3> routeVectorList;

    private Vector3 side;
    private Vector3 spawnPosition = new Vector3(0f, 0f, 0f);
    private Quaternion rotation = Quaternion.Euler(0f, 45f, 0f);

    private int currentTargetIndex = 0;
    public float speed = 5f;
    public float positionThreshold = 0.3f;


    private float timer = 0f; 

    private void Start()
    {
        
    }

    void Update()
    {
        SpawnPrefabs();
        prefabList.RemoveAll(obj => obj == null);

        if (PlayerPrefs.GetInt("cheatToggleState") == 1)
        {
            Cheat();
        }
        
    }

    private void Cheat()
    {
        
        timer += Time.deltaTime;
        
        if (timer >= timeInterval)
        {
            
            if (routeVectorList.Count > 0)
            {
                routeVectorList.RemoveAt(0);
            }
            timer = 0f; 
        }
       
        if (routeVectorList.Count > 0)
        {           
            Vector3 currentTargetPosition = routeVectorList[0];            
            Vector3 direction = (currentTargetPosition - ball.transform.position).normalized;            
            Vector3 newPosition = ball.transform.position + direction * speed * Time.deltaTime;
            ball.transform.position = new Vector3(newPosition.x, ball.transform.position.y, newPosition.z);
        }

    }

    void SpawnPrefabs()
    {
        while (prefabList.Count < numberOfCubes)
        {
            SpawnRandomSide(Random.Range(0, 2));
            if (prefabList.Count > 0) { spawnPosition += side; }
            GameObject spawnedPrefab = Instantiate(boxPrefab, spawnPosition, rotation);
            prefabList.Add(spawnedPrefab.gameObject);
            routeVectorList.Add(spawnPosition);            
        }
    }

    void SpawnRandomSide(int rng)
    {
        if (rng == 1)
        {
            side = new Vector3(0.7f, 0f, 0.7f);           
        }
        else
        {
            side = new Vector3(-0.7f, 0f, 0.7f);            
        }
    }

}
