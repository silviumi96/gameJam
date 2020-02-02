using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireInteractableLogic : Logic
{
    public override void action(Transform wire)
    {
        transform.GetComponentInParent<WireLogic>().action(wire);
    }
}
