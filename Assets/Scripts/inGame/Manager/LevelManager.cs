using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] LevelList_SO levelList_SO;

    GameObject levelChange;
    public Transform targetTransform;

    int currentLevelIndex = -1; 

    public void Start()
    {
        TargetInst();
    }
    private void Awake()

    {
        EventManager.LevelSuccess += TargetInst;
        EventManager.LevelFail += LevelReload;

    }



    private void OnDisable()
    {
        EventManager.LevelSuccess -= TargetInst;
        EventManager.LevelFail -= LevelReload;   
    }

    private void TargetInst()
    {
        
        currentLevelIndex++;

        if(levelChange)
            Destroy(levelChange);

        levelChange = Instantiate(levelList_SO.GetLevelWithIndex(currentLevelIndex).levelPrefab, targetTransform.transform.position , Quaternion.identity);
        Debug.Log("level inst " + currentLevelIndex);
    }


    private void LevelReload()
    {
      
        if (levelChange)
            Destroy(levelChange);

        levelChange = Instantiate(levelList_SO.GetLevelWithIndex(currentLevelIndex).levelPrefab, targetTransform.transform.position, Quaternion.identity);
        Debug.Log("level inst " + currentLevelIndex);
    }


}
