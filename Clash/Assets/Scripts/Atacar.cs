using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atacar : MonoBehaviour
{
    BehaviourTree bt;
  
    
    public void Atack(int dano)
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(bt.Enemy);
        foreach (GameObject enemy in enemies)
        {
            if (Vector3.Distance(enemy.transform.position, bt.transform.position) < bt.range)
            {
                var enemyRef = enemy.GetComponent<BehaviourTree>();
                
                enemyRef.health -= dano;
            }
        }
    }
}
