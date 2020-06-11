using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceItem : MonoBehaviour
{
    public GameObject player;

    public Grid worldGrid;

    public GameObject planetParts;

    public void PlaceItemOnGrid(GameObject itemToPlace)
    {
        GridCol gridLocation = worldGrid.getColByVector3(player.transform.position);

        Debug.Log(gridLocation.objectInCol);

        if (gridLocation.objectInCol == null)
        {
            GameObject placedItem = Instantiate(itemToPlace, gridLocation.centerPoint, Quaternion.identity, planetParts.transform);
            worldGrid.getColByVector3(player.transform.position).objectInCol = placedItem;
        }
    }
}
