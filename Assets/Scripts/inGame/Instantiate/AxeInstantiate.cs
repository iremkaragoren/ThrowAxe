using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeInstantiate : MonoBehaviour
{
    [SerializeField] 
    Transform attackPoint;
    [SerializeField]
    GameObject weapon;


    private void OnEnable()
    {
        EventManager.AxeFail += AxeInst;
        EventManager.AxeSuccess += AxeInst;
    }
    private void OnDisable()
    {
        EventManager.AxeFail -= AxeInst;
        EventManager.AxeSuccess -= AxeInst;
    }


    private void AxeInst()
    {
        
        Instantiate(weapon, attackPoint.transform.position, attackPoint.transform.rotation);

        

    }
}
