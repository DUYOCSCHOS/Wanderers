using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Inventory<T> where T : ScriptableObject
{
    public Inventory(int size){
        slots = new InventorySlot<T>[size];
    }

    public InventorySlot<T>[] slots;

    public void SwapItem(int slot1, int slot2){
        
    }
}
