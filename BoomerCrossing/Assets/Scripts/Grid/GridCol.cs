using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridCol
{
    public Vector2 centerPoint;

    public Vector3 LeftTopPoint;
    public Vector3 RightTopPoint;
    public Vector3 LeftBottomPoint;
    public Vector3 RightBottomPoint;

    public GameObject objectInCol;

    public GridCol()
    {
    }

    public GridCol(Vector3 leftTopPoint, Vector3 rightTopPoint, Vector3 leftBottomPoint, Vector3 rightBottomPoint, float sizeX, float sizeY)
    {
        centerPoint = new Vector3(leftTopPoint.x + sizeX/2, leftTopPoint.y - sizeY/2, 0);
        LeftTopPoint = leftTopPoint;
        RightTopPoint = rightTopPoint;
        LeftBottomPoint = leftBottomPoint;
        RightBottomPoint = rightBottomPoint;
    }
}
