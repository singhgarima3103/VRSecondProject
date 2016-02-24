using UnityEngine;
using System.Collections;

public class CameraShake : MonoBehaviour {

    public float amplitude = 0.2f;
    public Transform shakingCameraTransform;


    void FixedUpdate()
    {
            Vector3 shakeDirection = Random.insideUnitSphere;
            shakeDirection.y = 0;
        shakingCameraTransform.position += shakeDirection * amplitude;
    }
}
