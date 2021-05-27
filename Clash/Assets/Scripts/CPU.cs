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
        StartCoroutine(RestoreEnergy());
        energy = 12;
    }



    IEnumerator EnemySpawn()
    {

        while (Time.timeScale == 1) 
        {
           int x = Random.Range(1, 4);
           
            if (x >= 1 && x < 2)
            {
                Instantiatetank();
            }
            else if (x >= 2 && x < 3)
            {
                Instantiatemago();
            }
            else Instantiatesup();

            yield return new WaitForSeconds(2f);
        }

        
    }



    private void Instantiatetank()
    {
        if (energy >= 3)
        {
            Instantiate(tank, new Vector3(0, 0, 16), Quaternion.identity);

            energy -= 3;
        }
    }

    private void Instantiatemago()
    {
        if (energy >= 5)
        {
            Instantiate(mago, new Vector3(7, 0, 16), Quaternion.identity);
            energy -= 5;
        }
    }


    private void Instantiatesup()
    {
        if (energy >= 4)
        {
            Instantiate(sup, new Vector3(-7, 0, 16), Quaternion.identity);
            energy -= 4;
        }
    }

    private IEnumerator RestoreEnergy()
    {
        while (energy < 13)
        {
            energy += 1;
            if (energy > 12)
            {
                energy = 12;
            }
            yield return new WaitForSeconds(2f);
        }

    }
}
