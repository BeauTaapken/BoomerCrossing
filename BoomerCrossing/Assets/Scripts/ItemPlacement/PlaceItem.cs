using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceItem : MonoBehaviour
{
    public GameObject planetParts;
    public GameObject player;

    public Grid worldGrid;

    public void PlaceItemOnGrid(GameObject itemToPlace)
    {

        GameObject placedItem = Instantiate(itemToPlace, new Vector3(player.transform.position.x, 26.0f, 0.0f), Quaternion.identity);
        placedItem.transform.parent = planetParts.transform;
    }
}
