using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : Logic
{

    public List<GameObject> lights;
    private bool isSwitched = false;

    public override void action() 
    {
        if (!isSwitched)
        {
            foreach (var light in lights)
            {
                light.GetComponent<Light>().intensity = 10;
            }
            isSwitched = true;
        }
        else 
        {
            foreach (var light in lights)
            {
                light.GetComponent<Light>().intensity = 1;
            }
            isSwitched = false;
        }
    }

    
}
