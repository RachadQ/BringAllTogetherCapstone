using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class LevelManager 
{
    private static int[] levelExperience  = new int[] { 1000 ,2000,3000,4000};


    public static int RequiredExperience(int Level)
    {


        return levelExperience[Level];
    }

 
}
