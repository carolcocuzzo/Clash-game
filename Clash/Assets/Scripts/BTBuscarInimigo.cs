using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BTBuscarInimigo : BTNode
{
    
    public override IEnumerator Run(BehaviourTree bt)
    { 
        status = Status.FAILURE;


        if (GameObject.FindGameObjectWithTag(bt.Enemy))
        {
            status = Status.SUCCESS;
        }


        yield break;

    }
}
