using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPlacement : MonoBehaviour
{
    public List<GameObject> trees;
    public List<GameObject> stones;

    public int treeAmount;
    public int stoneAmount;

    public Grid worldGrid;

    public GameObject planetParts;

    // Start is called before the first frame update
    public void spawnObjects()
    {
        Spawner(trees, treeAmount);
        Spawner(stones, stoneAmount);
    }

    public void Spawner(List<GameObject> objectList, int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            int randomRow = Random.Range(0, worldGrid.rows.Count);

            int randomCol = Random.Range(0, worldGrid.rows[randomRow].cols.Count);

            GridCol randomGrid = worldGrid.rows[randomRow].cols[randomCol];

            if (randomGrid.objectInCol == null)
            {
                int randomLocation = Random.Range(0, objectList.Count);

                GameObject placedItem = Instantiate(objectList[randomLocation], randomGrid.centerPoint, Quaternion.identity, planetParts.transform);
                randomGrid.objectInCol = placedItem;
            }
        }
    }
}
