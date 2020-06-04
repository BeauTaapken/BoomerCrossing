using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]


public class Grid : ScriptableObject
{
    public GameObject redSphere;
    public GameObject greenSphere;

    public int GridSizeY;
    public int GridSizeX;

    public float Radius;

    public float ColSizeX;
    public float RowSizeY;

    public float OffsetX;
    public float OffsetY;

    public List<GridRow> rows = new List<GridRow>();

    public List<Vector3> GridPoints = new List<Vector3>();

    void CreatePoints(GameObject gridObject)
    {
        float x = 0f;
        float y = 0f;

        float angle = 0f;
        for (float z = 0; z < (GridSizeX); z++)
        {
            for (int i = 0; i < (GridSizeY + 1); i++)
            {
                x = Mathf.Sin(Mathf.Deg2Rad * angle) * Radius;
                y = Mathf.Cos(Mathf.Deg2Rad * angle) * Radius;

                GridPoints.Add(new Vector3(x, y, (z * ColSizeX)));
                GameObject s1 = Instantiate(redSphere, gridObject.transform);
                s1.transform.position = new Vector3(x, (y + OffsetY), ((z * ColSizeX) + OffsetX));

                angle += (360f / GridSizeY);
            }
        }
       
    }

    public void GenerateGrid(GameObject gridObject)
    {
        CreatePoints(gridObject);
        Vector2 generateColFromPoint = new Vector2(OffsetX, OffsetY);
        float angle = 0f;

        for (int y = 0; y < GridSizeY; y++)
        {
            GridRow row = new GridRow();

            generateColFromPoint = new Vector2(generateColFromPoint.x + Mathf.Sin(Mathf.Deg2Rad * angle) * Radius, generateColFromPoint.y + Mathf.Cos(Mathf.Deg2Rad * angle) * Radius);

            for (int x = 0; x < GridSizeX; x++)
            {
                Vector2 leftTopPoint = generateColFromPoint;
                Vector2 rightTopPoint = new Vector2(generateColFromPoint.x + ColSizeX, generateColFromPoint.y);
                Vector2 leftBottomPoint = new Vector2(generateColFromPoint.x, generateColFromPoint.y - RowSizeY);
                Vector2 rightBottomPoint = new Vector2(generateColFromPoint.x + ColSizeX, generateColFromPoint.y - RowSizeY);

                generateColFromPoint = rightTopPoint;

                GridCol col = new GridCol(leftTopPoint, rightTopPoint,leftBottomPoint, rightBottomPoint, ColSizeX, RowSizeY);

                row.cols.Add(col);
            }

            generateColFromPoint = row.cols[0].LeftBottomPoint;
            angle += (360f / RowSizeY);
            rows.Add(row);         
        }

        //DebugGrid();
    }

    private void DebugGrid()
    {
        Debug.Log("Rows: " + rows.Count);
        int colcount = 0;

        foreach (GridRow gridRow in rows)
        {
            colcount += gridRow.cols.Count;

            foreach(GridCol col in gridRow.cols)
            {
                Debug.Log(col.LeftTopPoint);
                Debug.Log(col.RightTopPoint);

                GameObject s1 = Instantiate(redSphere);
                GameObject s2 = Instantiate(redSphere);
                GameObject s3 = Instantiate(redSphere);
                GameObject s4 = Instantiate(redSphere);
                GameObject s5 = Instantiate(greenSphere);

                s1.transform.position = new Vector3(col.LeftTopPoint.x, 0, col.LeftTopPoint.y);
                s2.transform.position = new Vector3(col.RightTopPoint.x, 0, col.RightTopPoint.y);
                s3.transform.position = new Vector3(col.LeftBottomPoint.x, 0, col.LeftBottomPoint.y);
                s4.transform.position = new Vector3(col.RightBottomPoint.x, 0, col.RightBottomPoint.y);

                s5.transform.position = new Vector3(col.centerPoint.x, 0, col.centerPoint.y);
            }
        }

        Debug.Log("Cols:" + colcount);
    }
}
