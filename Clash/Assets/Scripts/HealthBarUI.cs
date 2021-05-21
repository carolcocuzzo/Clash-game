using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarUI: MonoBehaviour
{

    [SerializeField] private Image healthBarFillImage;
    //[SerializeField] private Dano dano; // Aqui vai colocar o script que tem o dano;

    [SerializeField]
    [Min(0.1f)]
    private float speed = 2; 


    private void LateUpate()
    {

        //float healthPercent = (float)dano.VidaAtual / dano.MaxVida; // Acessa o script e as funçoes 
        //healthBarFillImage.fillAmount = Mathf.Lerp(healthBarFillImage.fillAmount, healthPercent, Time.deltaTime * speed);


        //healthBarFillImage.fillAmount = healthPercent;

    }




}

