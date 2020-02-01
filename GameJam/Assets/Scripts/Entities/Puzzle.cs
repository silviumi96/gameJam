using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle : MonoBehaviour
{
    public List<GameObject> triggers;
    public bool isComplete = false;

    public void checkCompletion() 
    {
        foreach (var trigger in triggers)
        {
            bool isTriggered = trigger.GetComponentInChildren<Switch>().isTriggered;
            if (!isTriggered)
                return;
        }

        isComplete = true;
        transform.parent.GetComponent<LevelController>().addCompletedPuzzle(1);
    }

}
