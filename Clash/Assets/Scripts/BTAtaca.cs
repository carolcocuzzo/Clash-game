using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BTAtaca : BTNode
{

    Atacar atacar;
    public override IEnumerator Run(BehaviourTree bt)
    {
        status = Status.RUNNING;

        GameObject[] enemies = GameObject.FindGameObjectsWithTag(bt.Enemy);
        foreach (GameObject enemy in enemies)
        {
            if (Vector3.Distance(enemy.transform.position, bt.transform.position) < 1)
            {
                //while (enemy.health >= 10)
                while (enemy != null) 
                {
                    atacar.Atack(10);
                    yield return null;
                    
                }
            }

        }

        status = Status.SUCCESS; 
    }
}
