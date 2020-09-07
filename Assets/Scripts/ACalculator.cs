using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ACalculator : MonoBehaviour
{
    float v = 18F;
    float v1 = -10F;
    public Animator AnimatorBackGround;
    private string tempOp;

    public void funSum()
    {
        tempOp = "sum"; 
        clear();
    }

    public void funSub()
    {
        tempOp = "sub";
        clear();
    }

    public void next()
    {
        tempOp = "sum";
        clear();
        v += 18;
        GameObject.Find("Main Camera").transform.position = new Vector3(v, 0f, -10f);
    }

    public void next1()
    {
        tempOp = "sub";
        clear();
        v1 -= 10;
        GameObject.Find("Main Camera").transform.position = new Vector3(0f, v1, -10f);
    }

    public void gts()
    {
        tempOp = "sum";
        movingCamera();
    }

    public void gtm()
    {
        tempOp = "sub";
        movingCamera();
    }


    public void clear()
    {
        AnimatorBackGround = GameObject.Find("background").GetComponent<Animator>();
        AnimatorBackGround.Play("departure");
    }

    public void movingCamera()
    {
        if (tempOp == "sum") {
            GameObject.Find("Main Camera").transform.position = new Vector3(18f, 0f, -10f);
        }
        if (tempOp == "sub") {
            GameObject.Find("Main Camera").transform.position = new Vector3(0f, -10f, -10f);
        }
    }
}
