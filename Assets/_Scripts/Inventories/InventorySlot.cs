using UnityEngine;

[System.Serializable]
public struct InventorySlot<T> where T : ScriptableObject
{
    public T item;
    public int itemCount;
}
