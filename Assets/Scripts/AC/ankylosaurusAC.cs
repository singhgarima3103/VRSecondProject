using UnityEngine;
using System.Collections;

public class ankylosaurusAC : MonoBehaviour {

    public float timeBetweenAttacks = 1f;

    Animator anim;
    LayerMask dinoMask;
    LayerMask playerMask;
    public GameObject enemyBody;
    

    void Awake()
    {
        anim = GetComponent<Animator>();
        dinoMask = LayerMask.NameToLayer("Dinosaur");
        playerMask = LayerMask.NameToLayer("Player");
    }

    void OnTriggerEnter( Collider other)
    {
        if (other.gameObject == enemyBody)
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
