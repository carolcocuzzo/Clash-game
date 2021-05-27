using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField]
    private Image imageHealth;

    private BehaviourTree bt;

    private float fill;
    
    void Start()
    {
        bt = GetComponentInParent<BehaviourTree>();
        fill = 1;
    }

    
    void Update()
    {
        ChangeFillAmount();
    }


    void ChangeFillAmount()
    {
        fill = (float) bt.health / bt.maxHealth;
        imageHealth.fillAmount = fill;
    }
}
