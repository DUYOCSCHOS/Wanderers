[System.Serializable]
public class Stat
{
    public float baseValue = 0;
    public float bonusValue = 0;
    public float multiplier = 1;

    public float GetValue() => (baseValue + bonusValue) * multiplier;
    public float GetBaseValue() => baseValue;
    public float GetBonusValue() => bonusValue;
    public float GetMultiplier() => multiplier;

    public Stat WithBaseValue(float baseValue){
        this.baseValue = baseValue;
        return this;
    }
    public Stat WithBonusValue(float bonusValue){
        this.bonusValue = bonusValue;
        return this;
    }
    public Stat WithMultiplier(float multiplier){
        this.multiplier = multiplier;
        return this;
    }
}
