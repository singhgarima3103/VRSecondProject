using UnityEngine;
using System.Collections;

public class MeteorStartTimer : MonoBehaviour {

    public float timer = 0f;
    public GameObject meteorManager;
    public GameObject shakingCamera;
    public float startingTime = 0f;
    public float endTime = 0f;

    public GameObject player;
    public GameObject newCamera;

    void Start ()
    {

    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer > startingTime && timer <endTime)
        {
            meteorManager.SetActive(true);
            shakingCamera.SetActive(true);
        }

        if (timer > endTime)
        {
            Destroy(meteorManager);
            Destroy(shakingCamera);
            player.SetActive(false);
            newCamera.SetActive(true);
            
        }

    }

    void FixedUpdate()
    {

    }
}
