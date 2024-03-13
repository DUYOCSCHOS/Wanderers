using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Item/ConsumableItem/Food", fileName = "New Food")]
public class Food : ConsumableItem, StatsComponentVisitor
{
    public float duration;

    [Header("Bonus Stats")]
    public float maxHealth;
    public float maxStamina;
    public float maxMana;

    public override void Consume(){
        
    }

    public void Visit(HealthComponent healthComponent)
    {
        throw new System.NotImplementedException();
    }

    public void Visit(ManaComponent manaComponent)
    {
        throw new System.NotImplementedException();
    }

    public void Visit(StaminaComponent staminaComponent)
    {
        throw new System.NotImplementedException();
    }
}
