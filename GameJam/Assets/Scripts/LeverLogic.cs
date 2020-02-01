using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverLogic : Logic
{

    public override void action()
    {
        // do game
        transform.GetComponent<Switch>().setTrigger(!transform.GetComponent<Switch>().isTriggered);

        if (transform.GetComponent<Switch>().isTriggered)
            transform.position = transform.position + new Vector3(0, 1, 0);
        else
            transform.position = transform.position - new Vector3(0, 1, 0);
    }
}
