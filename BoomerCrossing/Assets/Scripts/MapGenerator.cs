using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    public Grid grid;
    public GameObject gridObject;
    public RandomPlacement ItemPlacement;

    // Start is called before the first frame update
    void Start()
    {
        grid.GenerateGrid(gridObject, gameObject.GetComponent<LineRenderer>());
        ItemPlacement.spawnObjects();
    }
}
