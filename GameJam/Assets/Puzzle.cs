using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle : MonoBehaviour
{
    public List<GameObject> triggers;
    public bool isComplete;

    public void checkCompletion() 
    {
        foreach (var trigger in triggers)
        {
            bool isTriggered = trigger.GetComponentInChildren<Switch>().isTriggered;
            if (!isTriggered)
                return;
        }

        isComplete = true;
        transform.parent.GetComponent<LevelController>().addCompletedPuzzle(transform.gameObject); // TODO: check if better method to propagate
    }

}
