using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room4SwitchLogic : Logic
{
    public GameObject powerPannel2;
    public GameObject powerPannel3;

    public override void action()
    {
        if (gameObject.layer == 8)
        {
            // todo: verify if this is correct
            foreach (Transform child in powerPannel2.transform)
            {
                child.GetComponent<Logic>().setPanelHasElectricity(true);
                child.gameObject.layer = 8;
            }
            foreach (Transform child in powerPannel3.transform)
            {
                child.GetComponent<Logic>().setPanelHasElectricity(false);
                child.gameObject.layer = 0;
            }
        }
    }
}
