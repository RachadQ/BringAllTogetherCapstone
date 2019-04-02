using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IRespawn 
{
    float time { get; set; }
    void Respawn(float SpawnRate);

}
