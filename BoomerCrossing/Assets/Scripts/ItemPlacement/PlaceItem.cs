using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceItem : MonoBehaviour
{
    public GameObject player;

    public Grid worldGrid;

    public void PlaceItemOnGrid(GameObject itemToPlace)
    {
        GridCol gridLocation = worldGrid.getColByVector3(player.transform.position);

        Debug.Log(gridLocation.objectInCol);

        if (gridLocation.objectInCol == null)
        {
            
            GameObject placedItem = Instantiate(itemToPlace, new Vector3(gridLocation.centerPoint.x, 0.0f, gridLocation.centerPoint.y), Quaternion.identity);
            //placedItem.transform.parent = planetParts.transform;
            worldGrid.getColByVector3(player.transform.position).objectInCol = placedItem;
        }
        else
        {
            Debug.Log("already contains item");
        }
    }
}
