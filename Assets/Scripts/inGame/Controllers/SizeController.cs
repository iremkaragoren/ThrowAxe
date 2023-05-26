using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeController : MonoBehaviour
{
    [SerializeField]
    public Vector3 scaleSize;
    void Start()
    {
        transform.localScale = scaleSize;

        
    }
}
