using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySlot
{
    public Item item;
    public int amount;

    public InventorySlot(Item item)
    {
        this.item = item;
        amount = 1;
    }
}
