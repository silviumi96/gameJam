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

            GetComponent<Animator>().Play("toggledOn");
            foreach (var light in lights)
			{
				light.GetComponent<Light>().intensity = 4f;
               // GetComponent<Animator>().SetBool("IsOn", true);
            }
			isSwitched = true;
		}
		else
		{

            GetComponent<Animator>().Play("toggledOff");
            foreach (var light in lights)
			{
				light.GetComponent<Light>().intensity = 0.3f;
                //GetComponent<Animator>().SetBool("IsOn", false);
            }
			isSwitched = false;
		}
	}
}
