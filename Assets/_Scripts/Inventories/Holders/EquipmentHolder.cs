using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentHolder : MonoBehaviour
{
    public Inventory<Equipment> inventory = new(10);
}
