using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gotostory : MonoBehaviour
{
    private void OnMouseDown()
    {
        ACalculator VarTemp = GameObject.Find("ACalculator").GetComponent<ACalculator>();
        VarTemp.gts();
    }
}
