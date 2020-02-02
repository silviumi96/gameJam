using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Typ2LeverLogic : Logic
{
	public override void action()
	{
		if (panelHasElectricity)
		{
			gameObject.layer = 8;
			foreach (Transform child in transform.parent)
			{
				if (!transform.GetComponent<Switch>().isTriggered)
				{
					if (child.name != this.name)
					{
						Debug.Log("Found sibling " + child.name);

						if (child.GetComponent<Switch>().isTriggered)
						{
							child.GetComponent<Switch>().setTrigger(!child.GetComponent<Switch>().isTriggered);
							child.GetComponentInChildren<Animator>().Play("toggledOff");
							child.GetComponent<Switch>().setTrigger(false);

							//child.position = child.position + new Vector3(0, 1, 0);
							//else
							//child.position = child.position - new Vector3(0, 1, 0);
						}
					}
				}
				transform.GetComponent<Switch>().setTrigger(!transform.GetComponent<Switch>().isTriggered);

                if (transform.GetComponent<Switch>().isTriggered)
                    GetComponentInChildren<Animator>().Play("toggledOn");

                else
                    GetComponentInChildren<Animator>().Play("toggledOff");
            }
		}
		else
		{
			gameObject.layer = 0;
		}
	}
}
