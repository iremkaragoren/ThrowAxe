using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCheckManager : MonoBehaviour
{
    [SerializeField]
    private LevelList_SO levelList;
    [SerializeField]
    private Level_SO currentLevel_SO;

    int currentLevel = 0;

    int usedThrow = 0;

    int successThrow = 0;
  
    private void Awake()
    {
        EventManager.AxeSuccess += OnAxeSuccess;
        EventManager.AxeFail += OnAxeFail;

    }
    private void OnDestroy()
    {
        EventManager.AxeSuccess -= OnAxeSuccess;
        EventManager.AxeFail -= OnAxeFail;

    }
    private void OnAxeFail()
    {
       usedThrow++;

       if(currentLevel_SO.totalThrows == usedThrow)
        {
            
           
            EventManager.LevelFail?.Invoke();

            successThrow = 0;
            usedThrow= 0;
           
           

        }
    }

    private void OnAxeSuccess()
    {
        usedThrow++;
        successThrow++;
       
        if (currentLevel_SO.successfulThrowsRequired == successThrow)
        {
           
            EventManager.LevelSuccess?.Invoke();
            currentLevel++;
            currentLevel_SO = levelList.GetLevelWithIndex(currentLevel);
            successThrow = 0; 
        }
    }




    private void Start()
    {
        currentLevel_SO = levelList.GetLevelWithIndex(0);
        
    }


   

}
