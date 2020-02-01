using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeLogic : Logic
{
    public GameObject water;

    public override void action()
    {
        if (transform.name == "RightPipe")
        {
            transform.GetComponent<Switch>().setTrigger(!transform.GetComponent<Switch>().isTriggered);

            if (transform.GetComponent<Switch>().isTriggered)
                water.GetComponent<WaterLogic>().setWaterLevel(0);
            else
                water.GetComponent<WaterLogic>().setWaterLevel(0.5f);
        } else
        {
            water.GetComponent<WaterLogic>().setWaterLevel(1);
            // TODO: handle death
        }
    }

    public void setWater(GameObject water)
    {
        this.water = water;
    }
}
