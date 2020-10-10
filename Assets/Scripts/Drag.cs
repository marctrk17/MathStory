using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    private Vector3 mOffset;
    private float mZCoord;
    public int i =1;


    void OnMouseDown()
    {
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        mOffset = gameObject.transform.position - GetMouseAsWorldPoint();
    }

    private Vector3 GetMouseAsWorldPoint()
    {
        // Pixel coordinates of mouse (x,y)
        Vector3 mousePoint = Input.mousePosition;
        // z coordinate of game object on screen
        mousePoint.z = mZCoord;
        // Convert it to world points
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    void OnMouseDrag()
    {
        transform.position = GetMouseAsWorldPoint() + mOffset;
        if (((transform.position.x< 115 && transform.position.x> 112) || (transform.position.x < 133 && transform.position.x > 130)
            || (transform.position.x < 151 && transform.position.x > 148) || (transform.position.x < 169 && transform.position.x > 166)
            || (transform.position.x < 189 && transform.position.x > 186) || (transform.position.x < 207 && transform.position.x > 204)
            || (transform.position.x < 225 && transform.position.x > 222) || (transform.position.x < 243 && transform.position.x > 240)
            || (transform.position.x < 261 && transform.position.x > 258) || (transform.position.x < 279 && transform.position.x > 276)
            || (transform.position.x < 297 && transform.position.x > 294) || (transform.position.x < 315 && transform.position.x > 312)
            || (transform.position.x < 333 && transform.position.x > 330) || (transform.position.x < 351 && transform.position.x > 348)
            ) && transform.position.y> 1 && transform.position.y< 1.6)
        {
            while (i == 1){
                Invoke("next", 1);
                i++;
            }
        }
    }

    void next()
    {
        i = 1;
        ACalculator VarTemp = GameObject.Find("ACalculator").GetComponent<ACalculator>();
        VarTemp.next();
    }

}
