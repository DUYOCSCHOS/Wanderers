using System.Threading;
using Cysharp.Threading.Tasks;

public class StatsModifier : Modifier
{
    public StatsModifier(Stats stats){
        this.stats = stats;
    }
    Stats stats = new();

    protected async override UniTask OnModify(){
        ModifyStats();
    }

    public override void StartOperation(){
        _ = OnModify();
    }

    public override void StopOperation(){
        ReverseStats();
        cancellationTokenSource.Cancel();
    }

    private void ModifyStats(){
        Player.Instance.stats.MaxHP.bonusValue += stats.MaxHP.bonusValue;
        Player.Instance.stats.MaxMP.bonusValue += stats.MaxMP.bonusValue;
        Player.Instance.stats.MaxSP.bonusValue += stats.MaxSP.bonusValue;
        Player.Instance.stats.PhysicalPower.bonusValue += stats.PhysicalPower.bonusValue;
        Player.Instance.stats.PhysicalResistance.bonusValue += stats.PhysicalResistance.bonusValue;
        Player.Instance.stats.MagicalPower.bonusValue += stats.MagicalPower.bonusValue;
        Player.Instance.stats.MagicalResistance.bonusValue += stats.MagicalResistance.bonusValue;
        Player.Instance.stats.CritRate.bonusValue += stats.CritRate.bonusValue;
        Player.Instance.stats.CritDamage.bonusValue += stats.CritDamage.bonusValue;
        Player.Instance.stats.Accuracy.bonusValue += stats.Accuracy.bonusValue;
        Player.Instance.stats.Speed.bonusValue += stats.Speed.bonusValue;

        Player.Instance.stats.MaxHP.multiplier *= stats.MaxHP.multiplier;
        Player.Instance.stats.MaxMP.multiplier *= stats.MaxMP.multiplier;
        Player.Instance.stats.MaxSP.multiplier *= stats.MaxSP.multiplier;
        Player.Instance.stats.PhysicalPower.multiplier *= stats.PhysicalPower.multiplier;
        Player.Instance.stats.PhysicalResistance.multiplier *= stats.PhysicalResistance.multiplier;
        Player.Instance.stats.MagicalPower.multiplier *= stats.MagicalPower.multiplier;
        Player.Instance.stats.MagicalResistance.multiplier *= stats.MagicalResistance.multiplier;
        Player.Instance.stats.CritRate.multiplier *= stats.CritRate.multiplier;
        Player.Instance.stats.CritDamage.multiplier *= stats.CritDamage.multiplier;
        Player.Instance.stats.Accuracy.multiplier *= stats.Accuracy.multiplier;
        Player.Instance.stats.Speed.multiplier *= stats.Speed.multiplier;
    }

    private void ReverseStats(){
        Player.Instance.stats.MaxHP.bonusValue -= stats.MaxHP.bonusValue;
        Player.Instance.stats.MaxMP.bonusValue -= stats.MaxMP.bonusValue;
        Player.Instance.stats.MaxSP.bonusValue -= stats.MaxSP.bonusValue;
        Player.Instance.stats.PhysicalPower.bonusValue -= stats.PhysicalPower.bonusValue;
        Player.Instance.stats.PhysicalResistance.bonusValue -= stats.PhysicalResistance.bonusValue;
        Player.Instance.stats.MagicalPower.bonusValue -= stats.MagicalPower.bonusValue;
        Player.Instance.stats.MagicalResistance.bonusValue -= stats.MagicalResistance.bonusValue;
        Player.Instance.stats.CritRate.bonusValue -= stats.CritRate.bonusValue;
        Player.Instance.stats.CritDamage.bonusValue -= stats.CritDamage.bonusValue;
        Player.Instance.stats.Accuracy.bonusValue -= stats.Accuracy.bonusValue;
        Player.Instance.stats.Speed.bonusValue -= stats.Speed.bonusValue;

        Player.Instance.stats.MaxHP.multiplier /= stats.MaxHP.multiplier;
        Player.Instance.stats.MaxMP.multiplier /= stats.MaxMP.multiplier;
        Player.Instance.stats.MaxSP.multiplier /= stats.MaxSP.multiplier;
        Player.Instance.stats.PhysicalPower.multiplier /= stats.PhysicalPower.multiplier;
        Player.Instance.stats.PhysicalResistance.multiplier /= stats.PhysicalResistance.multiplier;
        Player.Instance.stats.MagicalPower.multiplier /= stats.MagicalPower.multiplier;
        Player.Instance.stats.MagicalResistance.multiplier /= stats.MagicalResistance.multiplier;
        Player.Instance.stats.CritRate.multiplier /= stats.CritRate.multiplier;
        Player.Instance.stats.CritDamage.multiplier /= stats.CritDamage.multiplier;
        Player.Instance.stats.Accuracy.multiplier /= stats.Accuracy.multiplier;
        Player.Instance.stats.Speed.multiplier /= stats.Speed.multiplier;
    }
}
