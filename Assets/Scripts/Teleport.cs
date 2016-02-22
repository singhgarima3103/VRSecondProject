using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour {

    public Transform target;
    

    

    void OnTriggerEnter( Collider collider)
    {
       
        if (collider.gameObject.tag == "Player" )
        {
            collider.transform.position = target.transform.position;
        }
        
    }
}
