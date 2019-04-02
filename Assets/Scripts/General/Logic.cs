using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Logic 
{

    
    // roll chance for items drop
    public static bool RollDice(float _chance, int maxLoot = 100)
    {
       //roll 0 to 99
       int rnd = Random.Range(1, maxLoot);
       if (rnd < _chance)
        {
        return true;
        }
        return false;
    }

    // roll chance for items drop
    public static bool RollDice(int _chance, int maxLoot = 100)
    {
        //roll 0 to 99
        int rnd = Random.Range(1, maxLoot);
        if (rnd < _chance)
        {
            return true;
        }
        return false;
    }

    public static Vector3 GivenArea(Vector3 center,Vector3 size)
    {
        
       
        
        //Vector3 pos = center + new Vector3(Random.Range(-size.x / 2), size.x / 2), 1.0f, Random.Range(-size.x / 2), size.x / 2),);
        Vector3 pos = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), 0.7f, Random.Range(-size.z / 2, size.z));
        return pos;
        
    }
}
