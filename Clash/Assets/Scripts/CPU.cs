using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPU : MonoBehaviour
{
    [SerializeField]
    private GameObject tank;
    [SerializeField]
    private GameObject mago;
    [SerializeField]
    private GameObject sup;

    private int energy;

    Torre game;

    void Start()
    {
        StartCoroutine(EnemySpawn());
    }



    IEnumerator EnemySpawn()
    {

        while (!game.gameOver) 
        {
           int x = Random.Range(1, 4);
           
            if (x >= 1 && x < 2)
            {
                InstantiateTank();
            }
            else if (x >= 2 && x < 3)
            {
                InstantiateMago();
            }
            else InstantiateSup();

            yield return new WaitForSeconds(2f);
        }

        
    }



    private void InstantiateTank()
    {
        if (energy >= 3)
        {
            Instantiate(tank, new Vector3(0, 0, 16), Quaternion.identity);

            energy -= 3;
        }
    }

    private void InstantiateMago()
    {
        if (energy >= 5)
        {
            Instantiate(mago, new Vector3(7, 0, 16), Quaternion.identity);
            energy -= 5;
        }
    }


    private void InstantiateSup()
    {
        if (energy >= 4)
        {
            Instantiate(sup, new Vector3(-7, 0, 16), Quaternion.identity);
            energy -= 4;
        }
    }
}
