using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeTrigger : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Target")
        {
            
            transform.SetParent(collision.transform);
          GetComponent<Rigidbody>().isKinematic= true;
            EventManager.AxeSuccess?.Invoke();
         
        }
        if(collision.gameObject.tag==  "Caravana")
        {
            Destroy(gameObject);
            EventManager.AxeFail?.Invoke();

        }

    }
}
