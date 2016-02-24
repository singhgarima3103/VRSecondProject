using UnityEngine;
using System.Collections;

public class ParticleStarter : MonoBehaviour {

    public GameObject particle;

    void OnTriggerEnter()
    {
        particle.SetActive(true);
    }
}
