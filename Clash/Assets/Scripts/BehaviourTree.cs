using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviourTree : MonoBehaviour
{
    public BTNode root;

    public string Enemy;
    public IEnumerator Execute()
    {
        while (true) {
            if (root == null) yield return null;
            yield return StartCoroutine(root.Run(this));
        }
    }
}
