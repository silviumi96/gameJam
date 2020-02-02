using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverLogic : Logic
{
    public override void action()
    {
        if (panelHasElectricity)
        {
            gameObject.layer = 8;
            transform.GetComponent<Switch>().setTrigger(!transform.GetComponent<Switch>().isTriggered);

            if (transform.GetComponent<Switch>().isTriggered)
            {
                Debug.Log("ENTEREWD");
                Debug.Log(GetComponentInChildren<Animator>().name);
                GetComponentInChildren<Animator>().Play("toggledOn");
            }
            else
            {
                Debug.Log("ENTEREWD off");
                Debug.Log(GetComponentInChildren<Animator>().name);
                GetComponentInChildren<Animator>().Play("toggledOff");
            }
        } else
        {
            gameObject.layer = 0;
        }
    }
}
