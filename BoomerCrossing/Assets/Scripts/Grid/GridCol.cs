using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridCol
{
    public Vector2 centerPoint;

    public Vector2 LeftTopPoint;
    public Vector2 RightTopPoint;
    public Vector2 LeftBottomPoint;
    public Vector2 RightBottomPoint;

    public GameObject objectInCol;

    public GridCol()
    {
    }

    public GridCol(Vector3 leftTopPoint, Vector3 rightTopPoint, Vector3 leftBottomPoint, Vector3 rightBottomPoint, float sizeX, float sizeY)
    {
        centerPoint = new Vector2(leftTopPoint.x + sizeX/2, leftTopPoint.y - sizeY/2);
        LeftTopPoint = leftTopPoint;
        RightTopPoint = rightTopPoint;
        LeftBottomPoint = leftBottomPoint;
        RightBottomPoint = rightBottomPoint;
    }
}
