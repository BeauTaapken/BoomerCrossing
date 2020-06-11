using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridCol
{
    public Vector3 centerPoint;

    public Vector2 LeftTopPoint;
    public Vector2 RightTopPoint;
    public Vector2 LeftBottomPoint;
    public Vector2 RightBottomPoint;

    public GameObject objectInCol;

    public GridCol()
    {
    }

    public GridCol(Vector2 leftTopPoint, Vector2 rightTopPoint, Vector2 leftBottomPoint, Vector2 rightBottomPoint, float sizeX, float sizeY)
    {
        centerPoint = new Vector3(leftTopPoint.x + sizeX/2, 0, leftTopPoint.y - sizeY / 2);
        LeftTopPoint = leftTopPoint;
        RightTopPoint = rightTopPoint;
        LeftBottomPoint = leftBottomPoint;
        RightBottomPoint = rightBottomPoint;
    }
}
