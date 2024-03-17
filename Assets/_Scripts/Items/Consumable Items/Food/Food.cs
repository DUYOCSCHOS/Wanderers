using UnityEngine;

[CreateAssetMenu(menuName = "Item/Consumable Item/Food", fileName = "New Food")]
public class Food : ConsumableItem
{
    public float duration;

    [Header("Bonus Stats")]
    public Stats stats = new Stats();

    public override void Consume(){
        Effect effect = new Effect(name, description, sprite, duration)
        .AddModifier(new StatsModifier(stats));
        Player.Instance.effectSystem.effects.Add(effect.Init());
    }
}
