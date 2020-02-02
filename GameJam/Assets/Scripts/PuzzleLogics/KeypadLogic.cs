using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeypadLogic : Logic
{
    public static string correctCode = "7952";
    public static string playerCode = "";

    public static int totalDigits = 0;

    public GameObject Switch4;

    public override void action()
    {
        Debug.Log(playerCode);
        if (totalDigits == 4)
        {
            if (playerCode == correctCode)
            {
                Switch4.gameObject.layer = 8;
                Debug.Log("Correct!");
            } else
            {
                Switch4.gameObject.layer = 0;
                playerCode = "";
                totalDigits = 0;
                Debug.Log("You are the weakeast link!");
            }
        }
    }

    public void OnMouseUp()
    {
        playerCode = gameObject.name;
        totalDigits += 1;
    }
}
