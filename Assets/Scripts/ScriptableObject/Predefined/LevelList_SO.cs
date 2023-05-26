using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LevelList", menuName = "ThisGame/Levels/LevelList", order = 1)]
public class LevelList_SO : ScriptableObject
{
    [SerializeField]
    Level_SO[] levelArray;

    public Level_SO GetLevelWithIndex(int currentLevel)
    {


        if (levelArray.Length <= currentLevel)
            return levelArray[currentLevel % levelArray.Length];

        return levelArray[currentLevel];
    }



}

