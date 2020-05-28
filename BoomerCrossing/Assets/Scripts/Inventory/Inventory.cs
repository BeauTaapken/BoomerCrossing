using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]

public class Inventory: ScriptableObject
{
    public List<InventorySlot> slots = new List<InventorySlot>();

    public int size;

    public InventoryState tryAddItem(Item item)
    {
        InventorySlot exsistingSlot = getSlotByItem(item);
        if(exsistingSlot != null)
        {
            exsistingSlot.amount += 1;
            Debug.Log("Slot that holds item: " + item.name + " holds " + exsistingSlot.amount + " " + item.name);
            return InventoryState.ADDEDSUCCESFULL;
        }
        else
        {
            if (slots.Count < size)
            {
                slots.Add(new InventorySlot(item));
                return InventoryState.ADDEDSUCCESFULL;
            }
            else
            {
                return InventoryState.FULL;
            }
        }       
    }

    public bool tryRemoveItem(Item item)
    {
        InventorySlot slot = getSlotByItem(item);

        if(slot!= null)
        {
            slot.amount--;

            if (slot.amount <= 0)
            {
                slots.Remove(slot);
            }

            Debug.Log("Slot amount left: " + slot.amount);

            return true;
        }

        return false;
    }

    private InventorySlot getSlotByItem(Item item)
    {
        return slots.Find(I => I.item.name == item.name);
    }
}
