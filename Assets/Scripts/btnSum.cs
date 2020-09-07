using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btnSum : MonoBehaviour
{
    private void OnMouseDown()
    {
        ACalculator VarTemp = GameObject.Find("ACalculator").GetComponent<ACalculator>();
        VarTemp.funSum();
    }
}
