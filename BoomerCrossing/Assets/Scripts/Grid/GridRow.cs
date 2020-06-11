using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridRow 
{
    public List<GridCol> cols = new List<GridCol>();

    public Vector2 LeftTopPoint { 
        get 
        {
            if(cols.Count > 0)
            {
                return cols[0].LeftTopPoint;
            }
            return Vector3.zero;
        } 
    }

    public Vector2 RightBottomPoint
    {
        get
        {
            if (cols.Count > 0)
            {
                return cols[cols.Count].RightBottomPoint;
            }
            return Vector3.zero;
        }
    }

    public List<GridCol> getGameObjectsInColsByTag(string tag)
    {
       return cols.FindAll(c => c.objectInCol.tag == tag);
    }

}
