using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class SpawnManager : MonoBehaviour
{

    [SerializeField]
    private List<Spawn> spawnObject;
    public List<Spawn> SpawnObject { get { return spawnObject; } set { spawnObject = value; } }


    [SerializeField]
    private Vector3 center;
    public Vector3 Center { get { return center; } set { center = value; } }

    [SerializeField]
    private Vector3 size;
    public Vector3 Size { get { return size; } set { size = value; } }

    private void Start()
    {
      
        Init();
    }

    public void Init()
    {

        foreach (Spawn spawnObjects in spawnObject)
        {
            GameObject[] obj = new GameObject[spawnObjects.SpawnAmount];
            foreach (GameObject objects in obj)
            {
                Vector3 position = new Vector3(Random.Range(-size.x / 2, size.x / 2), 1.043333f, Random.Range(-size.z / 2, size.z));

                Instantiate(spawnObjects.SpawnMonsters, position, Quaternion.identity);
                
            }
                
             
                //myMonster.transform.parent = parent;
            

        }
    }
 

    private void OnDrawGizmos()
    {

        Gizmos.color = new Color(1, 0, 0.5f);
        Gizmos.DrawCube(center, size);
    }


}

