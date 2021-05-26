using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Comandos : MonoBehaviour
{
    [SerializeField]
    private Slider slider;

    [SerializeField]
    private GameObject tank;
    [SerializeField]
    private GameObject mago;
    [SerializeField]
    private GameObject sup;
    public Vector3 position;

    [SerializeField]
    float maxEnergy;
    [SerializeField]
    float energy;

    float energyValue;

    [SerializeField]
    private TextMeshProUGUI textEnergy;


    private void Start()
    {
        StartCoroutine(RestoreEnergy());
        
    }

    private void Update()
    {
        energyValue = energy;
        slider.value = energyValue;
        textEnergy.text = energyValue.ToString();
        
    }

    public void InstantiateTank()
    {
        if (energy >= 3)
        {
            Instantiate(tank, new Vector3(0, 0, -9), Quaternion.identity);
            
            energy -= 3;
        }
    }

    public void InstantiateMago()
    {
        if (energy >= 5)
        {
            Instantiate(mago, new Vector3(7, 0, -9), Quaternion.identity);
            energy -= 5;
        }
    }


    public void InstantiateSup()
    {
        if (energy >= 4)
        {
            Instantiate(sup, new Vector3(-7, 0 -9), Quaternion.identity);
            energy -= 4;
        }
    }


    public IEnumerator RestoreEnergy()
    {
        while(energy <= 12)
        {
            energy += 1;
            yield return new WaitForSeconds(2f);
        }

    }


}
