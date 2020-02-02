using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Logic : MonoBehaviour
{
    public bool panelHasElectricity;
    public bool isActiveLogic = true;
    // Start is called before the first frame update
    public void doAction()
    {
        if (isActiveLogic)
        {
            action();
        }
    }

	// Start is called before the first frame update
	public virtual void action() { }

	public virtual void action(Transform tran)
	{
	}
}
