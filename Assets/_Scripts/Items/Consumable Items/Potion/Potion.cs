using UnityEngine;

[CreateAssetMenu(menuName = "Item/Consumable Item/Potion", fileName = "New Potion")]
public class Potion : ConsumableItem, ComponentVisitor
{
    [Header("Bonus Stats")]
    public float bonusHP;
    public float bonusSP;
    public float bonusMP;

    public override void Consume(){
        Player.Instance.Accept(this);
    }

    public void Visit(HealthComponent healthComponent){
        healthComponent.CurrentHP += bonusHP;
    }

    public void Visit(ManaComponent manaComponent){
        manaComponent.CurrentMP += bonusMP;
    }

    public void Visit(StaminaComponent staminaComponent){
        staminaComponent.CurrentSP += bonusSP;
    }
}
