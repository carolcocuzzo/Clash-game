using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
    BehaviourTree behaviour;
    void Start()
    {
        behaviour = GetComponent<BehaviourTree>();

        BTSequence sequence1 = new BTSequence();
        sequence1.children.Add(new BTBuscarInimigo());
        sequence1.children.Add(new BTMover());
        sequence1.children.Add(new BTAtaca());

        behaviour.root = sequence1;

        StartCoroutine(behaviour.Execute());
    }

}
