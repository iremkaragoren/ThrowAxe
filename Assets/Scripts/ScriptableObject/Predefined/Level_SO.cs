using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Level", menuName = "ThisGame/Levels/Level", order = 1)]
public class Level_SO : ScriptableObject
{

    [SerializeField]
    GameObject LevelPrefab;

  
    public int totalThrows;

  
    public int successfulThrowsRequired;

    public int TotalThrows
    {
        get { return totalThrows; }
        set { totalThrows = value; }
    }

    public int SuccessfulThrowsRequired
    {
        get { return successfulThrowsRequired; }
        set { successfulThrowsRequired = value; }
    }

    public GameObject levelPrefab { get => LevelPrefab; }


}
