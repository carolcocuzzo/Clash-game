using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BTNode
{
    public enum Status { RUNNING, SUCCESS, FAILURE};

    public Status status;

    public List<BTNode> children = new List<BTNode>(); 
    
    public abstract IEnumerator Run(BehaviourTree bt);

    public void Print()
    {
        string cor = "cyan";
        if (status == Status.SUCCESS) cor = "green";
        if (status == Status.FAILURE) cor = "orange";

        Debug.Log("<color=" + cor + ">" + this.ToString() + ":" + status.ToString());
    }
}
