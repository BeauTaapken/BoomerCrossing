using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    public Grid grid;
    public GameObject gridObject;
    public RandomPlacement ItemPlacement;
    public GameObject House;

    // Start is called before the first frame update
    void Start()
    {
        grid.GenerateGrid(gridObject, gameObject.GetComponent<LineRenderer>());

        //this needs to be fixed
        if(House != null)
        {
            GameObject house = Instantiate(House);
            grid.rows[15].cols[15].objectInCol = house;
            grid.rows[15].cols[16].objectInCol = house;
            grid.rows[15].cols[17].objectInCol = house;
            grid.rows[15].cols[18].objectInCol = house;
            house.transform.position = grid.rows[15].cols[15].centerPoint;
        }
        //end of fix

        ItemPlacement.spawnObjects();
    }
}
