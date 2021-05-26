using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
    BehaviourTree behaviour;

    public Animator animator;

    Vector3 lastPos;

    void Start()
    {

        animator = GetComponent<Animator>();
        behaviour = GetComponent<BehaviourTree>();
        lastPos = transform.position;


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
            StartCoroutine("Die");
        }

 
     
    }

    private void LateUpdate()
    {
        if (IsMoving())
        {
            animator.SetBool("walking", true);
        }
        else animator.SetBool("walking", false);
    }


    public  IEnumerator Die()
    {
        animator.SetBool("die", true);
        GetComponent<Collider>().enabled = false;
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }

    public bool IsMoving()
    {
        var displacement = transform.position - lastPos;
        lastPos = transform.position;
        Debug.Log("Moving");
        return displacement.magnitude > 0.001; // return true if char moved 1mm
    }


}
