using UnityEngine;
using System.Collections;

public class ankylosaurusAC : MonoBehaviour {

    public float timeBetweenAttacks = 1f;

    Animator anim;
    LayerMask dinoMask;
    LayerMask playerMask;
    public GameObject player;
    float timer;

    void Awake()
    {
        anim = GetComponent<Animator>();
        dinoMask = LayerMask.NameToLayer("Dinosaur");
        playerMask = LayerMask.NameToLayer("Player");
    }

    void OnTriggerEnter( Collider other)
    {
        if (other.gameObject == player)
        {
            anim.SetTrigger("Attack");
            anim.SetBool("HaveEnemy", true);
        }
           
        
    }

    void OnTriggerExit (Collider other)
    {
        
            anim.SetBool("HaveEnemy", false);
        
    }

    void FixedUpdate()
    {
        
    }
}
