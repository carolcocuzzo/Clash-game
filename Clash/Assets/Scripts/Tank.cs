using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
    BehaviourTree behaviour;

    public Animator animator;

    Vector3 lasPos;

    void Start()
    {

        animator = GetComponent<Animator>();
        behaviour = GetComponent<BehaviourTree>();
        lasPos = transform.position;


        BTSequence sequence1 = new BTSequence();
        sequence1.children.Add(new BTBuscarInimigo());
        sequence1.children.Add(new BTMover());
        sequence1.children.Add(new BTAtaca());

        behaviour.root = sequence1;

        StartCoroutine(behaviour.Execute());
    }


    private void Update()
    {
        if(behaviour.health <= 0)
        {
            Die();
        }

        /*if (lasPos != transform.position)
        {
            animator.SetBool("walking", true);
        }
        else animator.SetBool("walking", false);


        lasPos = transform.position;*/
     
    }


    void Die()
    {
        animator.SetBool("die", true);
        Collider.Destroy(gameObject);
    }


}
