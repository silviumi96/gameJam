using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetSetLogic : Logic
{

    public GameObject player;
    public GameObject lever;

    private bool gaveLever = false;
    public override void action()
    {
        Debug.Log("Entered action");
        if (!panelHasElectricity)
        {
            Debug.Log("Entered NOT hasElectricity");
            if (!gaveLever)
            {
                Debug.Log("Entered GAVE lever");
                Instantiate(lever, player.transform);
                //lever.transform.position = Camera.main.transform.forward * 100;
                gaveLever = true;
                panelHasElectricity = true;
                transform.gameObject.GetComponent<MeshRenderer>().enabled =false;
                transform.GetComponent<Switch>().setTrigger(false);
            }
        }
        else 
        {
            Debug.Log("Entered HAS hasElectricity");
                Debug.Log("Remvoed Child");
                panelHasElectricity = false;
                gaveLever = false;
                player.transform.GetChild(player.transform.childCount-1).gameObject.SetActive(false);
                   transform.gameObject.GetComponent<MeshRenderer>().enabled = true;
            transform.GetComponent<Switch>().setTrigger(true);
        }
    }
}
