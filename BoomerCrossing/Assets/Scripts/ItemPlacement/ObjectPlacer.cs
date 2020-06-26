using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPlacer : MonoBehaviour
{
    public bool placing;

    public GameObject selectedObject;

    public Grid grid;

    void Update()
    {
        if(placing && Input.GetMouseButtonDown(0) || Input.touchCount > 0)
        {
            Vector2 mousePos = Vector3.zero;

            mousePos.x = Input.mousePosition.x;
            mousePos.y = Input.mousePosition.y;

            Vector3 location = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, Camera.main.nearClipPlane));

            Debug.Log(location);

            GridCol col = grid.getColByVector3(location);

            if (col != null)
            {
                placing = false;
                if(col.objectInCol == null)
                {
                    GameObject placedObject = Instantiate(selectedObject);
                    placedObject.transform.position = col.centerPoint;
                    placedObject.transform.position = new Vector3(placedObject.transform.position.x, 5.0f, placedObject.transform.position.z);
                    col.objectInCol = placedObject;
                }
            }
        }
    }
}
