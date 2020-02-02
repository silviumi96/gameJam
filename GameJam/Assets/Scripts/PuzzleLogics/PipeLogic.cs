using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeLogic : Logic
{
    public GameObject water;
    public GameObject powerPannel3;

    public override void action()
    {
        if (transform.name == "RightPipe")
        {
            transform.GetComponent<Switch>().setTrigger(!transform.GetComponent<Switch>().isTriggered);

            if (transform.GetComponent<Switch>().isTriggered)
            {
                water.GetComponent<WaterLogic>().setWaterLevel(0);
                foreach (Transform child in powerPannel3.transform)
                {
                    child.GetComponent<Logic>().setPanelHasElectricity(true);
                    child.gameObject.layer = 8;
                }
            }
            else
            {
                water.GetComponent<WaterLogic>().setWaterLevel(0.5f);
                foreach (Transform child in powerPannel3.transform)
                {
                    child.GetComponent<Logic>().setPanelHasElectricity(false);
                    child.gameObject.layer = 0;
                }
            }
        } else
        {
            water.GetComponent<WaterLogic>().setWaterLevel(1);
            foreach (Transform child in powerPannel3.transform)
            {
                child.GetComponent<Logic>().setPanelHasElectricity(false);
                child.gameObject.layer = 0;
            }
            // TODO: handle death
        }
    }

    public void setWater(GameObject water)
    {
        this.water = water;
    }
}
