using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectItem : MonoBehaviour
{
    private ObjectPlacer objectPlacer;

    public void Selected()
    {
        gameObject.GetComponent<Image>().color = Color.gray;
        GameObject objectToPlace = gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject;
        objectPlacer = GameObject.FindGameObjectWithTag("objectPlacer").GetComponent<ObjectPlacer>();
        objectPlacer.placing = true;
        objectToPlace.SetActive(true);
        objectPlacer.selectedObject = objectToPlace;
    }

    void Update()
    {
        if (objectPlacer != null)
        {
            if (objectPlacer.placing == false)
            {
                gameObject.GetComponent<Image>().color = Color.white;
            }
        }
    }
}
