using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviourTree : MonoBehaviour
{
    public BTNode root;

    public string Enemy;


    public Animator anim;

    BehaviourTree bt;

    public float maxHealth = 100;
    public float health = 100;
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
            if (enemy != null && Vector3.Distance(enemy.transform.position, transform.position) < range && health > 0 && 
                enemy.GetComponent<BehaviourTree>().health > 0)
            {
                if (anim != null)
                {
                    anim.SetTrigger("attacking");
                    anim.SetBool("walking", false);
                }
               
                enemy.GetComponent<BehaviourTree>().health -= dano;
               
            }
        }
    }
}
