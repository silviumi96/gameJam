using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Logic : MonoBehaviour
{
    public bool panelHasElectricity;

	public virtual void action() { }

	public virtual void action(Transform tran)
	{
	}

    public void setPanelHasElectricity(bool hasElectricity)
    {
        this.panelHasElectricity = hasElectricity;
    }
}
