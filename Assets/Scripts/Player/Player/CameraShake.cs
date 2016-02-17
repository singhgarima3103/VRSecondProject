using UnityEngine;
using System.Collections;

public class CameraShake : MonoBehaviour {

    public float amplitude = 0.2f;
    bool isShake = false;
    Transform headLocation;

    void Start()
    {
        headLocation = GetComponent<Transform>();
    }

    void OnTriggerEnter()
    {
        isShake = true;
    }

    void OnTriggerExit()
    {
        isShake = false;
    }

    void FixedUpdate()
    {
        if (isShake)
        {
            Vector3 shakeDirection = Random.insideUnitSphere;
            shakeDirection.y = 0;
            headLocation.position += shakeDirection * amplitude;
        }
    }
}
