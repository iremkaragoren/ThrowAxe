using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    [SerializeField]
    private LevelList_SO levelList;
    [SerializeField]
    private Level_SO currentLevel_SO;

    int successThrow;
     

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


    private void OnAxeSuccess()
    {
        successThrow = currentLevel_SO.SuccessfulThrowsRequired;

        if(successThrow == 0)
        { 

        }

    }

    private void OnAxeFail()
    {




    }
}
