using UnityEngine;
using System.Collections;

public class Trigger : MonoBehaviour {

    Ray playerRay;
    RaycastHit playerRaycastHit;
    int range = 10;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void Interact()
    {
        playerRay.origin = GetComponent<Transform>().position;
        playerRay.direction = GetComponent<Transform>().forward;
        Physics.Raycast(playerRay, out playerRaycastHit, range);
        // playerRaycastHit.collider.

    }
}
