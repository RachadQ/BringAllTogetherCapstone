using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class SpawnManager 
{

    [SerializeField]
    private List<Spawn> spawnObject;
    public List<Spawn> SpawnObject { get { return spawnObject; } set { spawnObject = value; } }

  
    private Vector3 position;
    public Vector3 Position { get { return position; } set { position = value; } }

    [SerializeField]
    private GameObject SpawnPoint;
    public GameObject SpawnPoints { get { return SpawnPoint; } set { SpawnPoint = value; } }

    [SerializeField]
    private Vector3 center;
    public Vector3 Center { get { return center; } set { center = value; } }

    [SerializeField]
    private Vector3 size;
    public Vector3 Size { get { return size; } set { size = value; } }



    public void Init(Transform center)
    {

        foreach (Spawn spawnObjects in spawnObject)
        {

            for (int i = 0; i < spawnObjects.SpawnAmount; i++)
            {
                
                Vector3 position = new Vector3(Random.Range(-size.x / 2, size.x / 2), 1.043333f, Random.Range(-size.z / 2, size.z));
                spawnObjects.EntityPosition[i] = position;
                GameObject myMonster = GameObject.Instantiate(spawnObjects.SpawnMonsters, spawnObjects.EntityPosition[i], Quaternion.identity);
                //myMonster.transform.parent = parent;
            }

        }
    }
    public Vector3 RandomPoint()
    {
        Vector3 position = new Vector3(Random.Range(-size.x / 2, size.x / 2), 1.043333f, Random.Range(-size.z / 2, size.z));
        return position;
    }

    private void OnDrawGizmos()
    {

        Gizmos.color = new Color(1, 0, 0.5f);
        Gizmos.DrawCube(SpawnPoint.transform.position, size);
    }

    public void Draw()
    {
        // Gizmos.color = new Color(1, 0, 0.5f);
       
            Gizmos.color = new Color(1, 0, 0.5f);
            Gizmos.DrawCube(SpawnPoint.transform.position, size);

        
    }


}
