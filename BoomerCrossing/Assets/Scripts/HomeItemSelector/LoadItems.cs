using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadItems : MonoBehaviour
{
    public List<GameObject> ItemSprites;
    public GameObject ListItemPrefab;
    public GameObject ContentLocation;

    private float contentLength;
    private float itemPosition;

    // Start is called before the first frame update
    void Start()
    {
        if (ListItemPrefab != null && ContentLocation != null)
        {
            foreach (GameObject item in ItemSprites)
            {
                GameObject instantiatedItem = Instantiate(ListItemPrefab);
                instantiatedItem.transform.position = new Vector3(0, itemPosition, 0);
                fenatureData furnitureData = item.GetComponent<fenatureData>();
                if (furnitureData != null)
                {
                    instantiatedItem.gameObject.transform.GetChild(0).GetComponent<Image>().sprite = furnitureData.image;
                }
                instantiatedItem.transform.SetParent(ContentLocation.transform, false);
            }
        }
        else
        {
            Debug.Log("Not all needed items are added");
        }
    }
}
