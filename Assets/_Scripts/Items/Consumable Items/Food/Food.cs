using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Item/Consumable Item/Food", fileName = "New Food")]
public class Food : ConsumableItem
{
    public float duration;

    [Header("Bonus Stats")]
    public Stats stats = new Stats();

    public override void Consume(){
        StatsEffect statsEffect = new StatsEffect(stats);
        //Player.Instance.effectSystem.effects.Add(statsEffect);
    }
}
