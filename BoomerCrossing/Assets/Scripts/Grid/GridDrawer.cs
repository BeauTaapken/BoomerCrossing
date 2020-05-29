using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridDrawer : MonoBehaviour
{
    public Grid grid;

    // Start is called before the first frame update
    void Start()
    {
        grid.GenerateGrid();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
