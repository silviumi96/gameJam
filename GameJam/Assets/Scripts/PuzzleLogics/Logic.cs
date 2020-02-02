using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Logic : MonoBehaviour
{
	public bool panelHasElectricity;

	// Start is called before the first frame update
	public virtual void action() { }

	public virtual void action(Transform tran)
	{
	}
}
