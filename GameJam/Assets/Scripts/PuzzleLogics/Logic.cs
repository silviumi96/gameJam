using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Logic : MonoBehaviour
{
    public bool panelHasElectricity;
    public bool isActiveLogic = true;
    // Start is called before the first frame update
    public abstract void action();

    public void doAction()
    {
        if (isActiveLogic)
        {
            action();
        }
    }
}
