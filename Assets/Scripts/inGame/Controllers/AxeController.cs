using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeController : MonoBehaviour
{

    [Header("Throw")]
    public int totalThrow;

    [Header("Force")]
    public KeyCode throwKey = KeyCode.Mouse0;
    public float throwForce;
    public float throwUpwardForce;

    bool readyToThrow;



    void Start()
    {
        readyToThrow = true;

    }

    void Update()
    {
        if (Input.GetKeyDown(throwKey) && readyToThrow && totalThrow > 0)
            Throw();

    }



    private void Throw()
    {

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
       

        RaycastHit hit;

        if (Physics.Raycast(Camera.main.transform.position, ray.direction, out hit, 300f))
        {
            
            if (hit.transform.gameObject.layer == 3)
            {
                return;
            }
            Vector3 direction = (hit.point - transform.position).normalized;

            Rigidbody rb = GetComponent<Rigidbody>();
            readyToThrow = false;

            rb.AddForce(direction * throwForce + Vector3.up * throwUpwardForce, ForceMode.Impulse);
        }





    }
}
