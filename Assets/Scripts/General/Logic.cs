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


}
