using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceItem : MonoBehaviour
{
    public GameObject planetParts;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlaceItemOnGrid(GameObject itemToPlace)
    {
        GameObject placedItem = Instantiate(itemToPlace, new Vector3(player.transform.position.x, 26.0f, 0.0f), Quaternion.identity);
        placedItem.transform.parent = planetParts.transform;
        Debug.Log("Placed item on player location");
    }
}
