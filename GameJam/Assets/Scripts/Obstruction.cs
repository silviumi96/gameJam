using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstruction : MonoBehaviour
{
    public void DisableObstruction()
    {
        // call transform animation DEATH
        // on animationEND call Destroy()

        Debug.Log("Obstruction Removed");
        //Destroy(gameObject);
        gameObject.SetActive(false);
        GetComponent<Animator>().Play("doorOpen");
        Debug.Log("anim played");
        Debug.Log(gameObject.name);
        Debug.Log(GetComponent<Animator>());
        //Destri
    }
}
