using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BTAtaca : BTNode
{

    public override IEnumerator Run(BehaviourTree bt)
    {
        status = Status.RUNNING;


        GameObject[] enemies = GameObject.FindGameObjectsWithTag(bt.Enemy);
        foreach (GameObject enemy in enemies)
        {
            if (Vector3.Distance(enemy.transform.position, bt.transform.position) < bt.range)
            {
                
                while (enemy != null) 
                {
                    bt.Atack(bt.damage);
                    yield return new WaitForSeconds(0.95f);
                    
                }
            }

        }

        status = Status.SUCCESS; 
    }
}
