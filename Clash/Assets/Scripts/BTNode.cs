using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BTNode
{
    public enum Status { RUNNING, SUCCESS, FAILURE};

    public Status status;

    public List<BTNode> children = new List<BTNode>(); 
    
    public abstract IEnumerator Run(BehaviourTree bt);
}
