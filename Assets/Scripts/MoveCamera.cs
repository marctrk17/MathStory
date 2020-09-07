using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public void MoveTheCamera()
    {
        ACalculator temp = GameObject.Find("ACalculator").GetComponent<ACalculator>();
        temp.movingCamera();
    }
}
