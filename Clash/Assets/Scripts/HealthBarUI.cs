using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarUI: MonoBehaviour
{

    [SerializeField] private Image healthBarFillImage;
    [SerializeField] private GameObject bt; 
    private BehaviourTree personagem;

    [SerializeField]
    [Min(0.1f)]
    private float speed = 2;

    private void Start()
    {
        personagem = bt.GetComponent<BehaviourTree>();
    }

    private void LateUpate()
    {

        float healthPercent = (float) personagem.health / personagem.maxHealth; // Acessa o script e as funçoes 
        healthBarFillImage.fillAmount = Mathf.Lerp(healthBarFillImage.fillAmount, healthPercent, Time.deltaTime * speed);


        healthBarFillImage.fillAmount = healthPercent;

    }




}

