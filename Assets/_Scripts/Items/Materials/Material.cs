using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Item/Material", fileName = "New Material")]
public class Material : Item
{
    private Material(){
        stack = 99;
    }
}
