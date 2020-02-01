using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverLogic : MonoBehaviour
{

    public void action()
    {
        // do game
        transform.GetComponent<Switch>().setTrigger(true);

        if (transform.GetComponent<Switch>().isTriggered)
            tranform.position = transform.position + new Vector3(1, 1, 1);

    }
}
