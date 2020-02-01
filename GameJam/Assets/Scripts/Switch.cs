using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public bool isTriggered = false;

    public void setTrigger(bool value)
    {
        isTriggered = value;
        transform.parent.GetComponent<Puzzle>().checkCompletion(); // event propagation
    }
}
