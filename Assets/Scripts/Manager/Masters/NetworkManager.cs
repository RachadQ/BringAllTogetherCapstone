using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetworkManager : MonoBehaviour
{
    public SpawnManager[] SpawnPoints;
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        createSpawnPoints();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void createSpawnPoints()
    {
        foreach (SpawnManager Spawns in SpawnPoints)
        {
            Spawns.SpawnPoints = new GameObject();
            Spawns.SpawnPoints.name = "spawnPoint";
            Spawns.SpawnPoints.transform.position = Spawns.Position;
            //  transform.position = position;

            foreach (Spawn _spawn in Spawns.SpawnObject)
            {
                _spawn.setAmountPositions(_spawn.SpawnAmount);
                
            }
            Spawns.Init(this.transform);
        }

    }

    private void OnDrawGizmos()
    {
        foreach (SpawnManager spawn in SpawnPoints)
        {
            spawn.Draw();
        }
    }
}
