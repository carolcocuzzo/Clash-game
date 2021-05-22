using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviourTree : MonoBehaviour
{
    public BTNode root;

    public string Enemy;


    public Animator anim;

    BehaviourTree bt;
    public int health = 100;
    public int damage = 10;
    public int range = 10;


    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    public IEnumerator Execute()
    {
        while (true) {
            if (root == null) yield return null;
            yield return StartCoroutine(root.Run(this));
        }
    }

    public void Atack(int dano)
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(Enemy);
        foreach (GameObject enemy in enemies)
        {
            if (Vector3.Distance(enemy.transform.position, transform.position) < range)
            {
                anim.SetTrigger("attacking");

                if (enemy.GetComponent<Animator>() != null)
                {
                   // enemy.GetComponent<BehaviourTree>().anim.SetTrigger("getHit");
                }
                enemy.GetComponent<BehaviourTree>().health -= dano;
               
            }
        }
    }
}
