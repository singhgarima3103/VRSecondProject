using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {

    NavMeshAgent navi;
    public GameObject aim;
    public float chasingRange;
    
    void Awake()
    {
        navi = GetComponent<NavMeshAgent>();

    }

    void FixedUpdate()
    {
        
        if (Vector3.Distance(transform.position, aim.transform.position) < chasingRange)
        {
            navi.SetDestination(aim.transform.position);

        }
        //Vector3.Distance(transform.position, aim.transform.position) < chasingRange
    }
}
