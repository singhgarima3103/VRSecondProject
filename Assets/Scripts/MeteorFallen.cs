using UnityEngine;
using System.Collections;

public class MeteorFallen : MonoBehaviour {

    public GameObject meteorObject;
    public Transform playerTransfrom;
    public float spawnWaitTime = 5f;
    public float timer = 0f;
    Vector3 difference;
    
    void Start()
    {
        difference.x = 270;
        difference.y = 0;
        difference.z = 180;

    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnWaitTime )
        {
            timer = 0f;
            Instantiate(meteorObject,playerTransfrom.position,meteorObject.transform.rotation);
            
        }
    }

    
}
