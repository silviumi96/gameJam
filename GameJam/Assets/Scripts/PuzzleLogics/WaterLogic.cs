using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterLogic : MonoBehaviour
{
    public float waterLevel = 0.5f;

    public void setWaterLevel(float futureWaterLevel)
    {
        this.waterLevel = futureWaterLevel;
    }

}
