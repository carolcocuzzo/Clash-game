using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torre : MonoBehaviour
{
    BehaviourTree behaviour;
    [SerializeField]
    private GameObject hud;
    [SerializeField]
    private GameObject telaVitoria;
    [SerializeField]
    private GameObject telaDerrota;

    [SerializeField]
    private AudioSource vitoria;
    [SerializeField]
    private AudioSource derrota;

    public bool gameOver;

    void Start()
    {
        behaviour = GetComponent<BehaviourTree>();

        BTSequence sequence1 = new BTSequence();
        sequence1.children.Add(new BTAtaca());

        behaviour.root = sequence1;

        StartCoroutine(behaviour.Execute());

        gameOver = false;
    }

    private void Update()
    {

        if (behaviour.health <= 0)
        {
            gameOver = true;

            if (gameObject.tag == "Vermelho")
            {
                Vitoria();
            }
            else Derrota();
        }
    }



    void Vitoria()
    {
        hud.SetActive(false);
        telaVitoria.SetActive(true);
        vitoria.Play();
        Time.timeScale = 0;
    }

    void Derrota()
    {
        hud.SetActive(false);
        telaDerrota.SetActive(true);
        derrota.Play();
        Time.timeScale = 0;
    }
}
