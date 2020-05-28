using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public Inventory inventory;

    public void AddItem(Item item)
    {
        InventoryState state = inventory.tryAddItem(item);

        if (state == InventoryState.ADDEDSUCCESFULL)
        {
            Debug.Log("Item added to invenotry");
        }
        else if(state == InventoryState.FULL)
        {
            Debug.Log("Inventory full");
        }

        Debug.Log(inventory.slots.Count);
    }

    public void RemoveItem(Item item)
    {
        inventory.tryRemoveItem(item);
    }
}
