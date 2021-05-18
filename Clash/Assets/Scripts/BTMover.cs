using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BTMover : BTNode   
{
    
    public override IEnumerator Run(BehaviourTree bt)
    {
        status = Status.RUNNING;

        GameObject alvo = null;
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(bt.Enemy);

        float distancia = Mathf.Infinity;

        foreach (GameObject enemy in enemies)
        {
            float distancia2 = Vector3.Distance(enemy.transform.position, bt.transform.position); 
            if (distancia2 < distancia)
            {
                alvo = enemy;
                distancia = distancia2;
            }
        }

        if (alvo)
        {
            while (Vector3.Distance(alvo.transform.position, bt.transform.position) > bt.range)
            {
                bt.transform.LookAt(alvo.transform);
                bt.transform.Translate(bt.transform.forward * Time.deltaTime);
                yield return null;
            }
            status = Status.SUCCESS;
        }

        if (status == Status.RUNNING) status = Status.FAILURE;

    }
    



}
