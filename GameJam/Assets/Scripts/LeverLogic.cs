using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverLogic : MonoBehaviour
{

    public void action()
    {
        transform.GetComponent<Switch>().setTrigger(true);

        if (transform.GetComponent<Switch>().isTriggered)
            transform.position = transform.position + new Vector3(1, 1, 1);
    }

}
