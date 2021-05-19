using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
    BehaviourTree behaviour;

    public Animator animator;

    void Start()
    {

        animator = GetComponent<Animator>();


        behaviour = GetComponent<BehaviourTree>();

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

     
    }


    void Die()
    {
        animator.SetBool("dies", true);
    }

}
