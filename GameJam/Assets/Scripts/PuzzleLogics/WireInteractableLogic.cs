using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireInteractableLogic : Logic
{
    GameObject wireBroken;
    public override void action(Transform wire)
    {

        wire.gameObject.SetActive(false);
        //wireBroken.SetActive(true);
        transform.GetComponentInParent<WireLogic>().action(wire);
    }
}
