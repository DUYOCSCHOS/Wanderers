using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsEffect : MonoBehaviour
{
    public StatsEffect(Stats stats){
        this.stats = stats;
    }
    Stats stats = new();
    Stats playerStats = new();

    public event Action EffectBeginEvent;
    public event Action EffectCollapseEvent;

    private void Awake(){
        playerStats = Player.Instance.stats;
        EffectBeginEvent += UpdateStats;
        EffectCollapseEvent += ReverseStats;
    }

    private void UpdateStats(){
        playerStats.MaxHP.bonusValue += stats.MaxHP.bonusValue;
        playerStats.MaxMP.bonusValue += stats.MaxMP.bonusValue;
        playerStats.MaxSP.bonusValue += stats.MaxSP.bonusValue;
        playerStats.PhysicalPower.bonusValue += stats.PhysicalPower.bonusValue;
        playerStats.PhysicalResistance.bonusValue += stats.PhysicalResistance.bonusValue;
        playerStats.MagicalPower.bonusValue += stats.MagicalPower.bonusValue;
        playerStats.MagicalResistance.bonusValue += stats.MagicalResistance.bonusValue;
        playerStats.CritRate.bonusValue += stats.CritRate.bonusValue;
        playerStats.CritDamage.bonusValue += stats.CritDamage.bonusValue;
        playerStats.Accuracy.bonusValue += stats.Accuracy.bonusValue;
        playerStats.Speed.bonusValue += stats.Speed.bonusValue;

        playerStats.MaxHP.multiplier *= stats.MaxHP.multiplier;
        playerStats.MaxMP.multiplier *= stats.MaxMP.multiplier;
        playerStats.MaxSP.multiplier *= stats.MaxSP.multiplier;
        playerStats.PhysicalPower.multiplier *= stats.PhysicalPower.multiplier;
        playerStats.PhysicalResistance.multiplier *= stats.PhysicalResistance.multiplier;
        playerStats.MagicalPower.multiplier *= stats.MagicalPower.multiplier;
        playerStats.MagicalResistance.multiplier *= stats.MagicalResistance.multiplier;
        playerStats.CritRate.multiplier *= stats.CritRate.multiplier;
        playerStats.CritDamage.multiplier *= stats.CritDamage.multiplier;
        playerStats.Accuracy.multiplier *= stats.Accuracy.multiplier;
        playerStats.Speed.multiplier *= stats.Speed.multiplier;
    }

    private void ReverseStats(){
        playerStats.MaxHP.bonusValue -= stats.MaxHP.bonusValue;
        playerStats.MaxMP.bonusValue -= stats.MaxMP.bonusValue;
        playerStats.MaxSP.bonusValue -= stats.MaxSP.bonusValue;
        playerStats.PhysicalPower.bonusValue -= stats.PhysicalPower.bonusValue;
        playerStats.PhysicalResistance.bonusValue -= stats.PhysicalResistance.bonusValue;
        playerStats.MagicalPower.bonusValue -= stats.MagicalPower.bonusValue;
        playerStats.MagicalResistance.bonusValue -= stats.MagicalResistance.bonusValue;
        playerStats.CritRate.bonusValue -= stats.CritRate.bonusValue;
        playerStats.CritDamage.bonusValue -= stats.CritDamage.bonusValue;
        playerStats.Accuracy.bonusValue -= stats.Accuracy.bonusValue;
        playerStats.Speed.bonusValue -= stats.Speed.bonusValue;

        playerStats.MaxHP.multiplier /= stats.MaxHP.multiplier;
        playerStats.MaxMP.multiplier /= stats.MaxMP.multiplier;
        playerStats.MaxSP.multiplier /= stats.MaxSP.multiplier;
        playerStats.PhysicalPower.multiplier /= stats.PhysicalPower.multiplier;
        playerStats.PhysicalResistance.multiplier /= stats.PhysicalResistance.multiplier;
        playerStats.MagicalPower.multiplier /= stats.MagicalPower.multiplier;
        playerStats.MagicalResistance.multiplier /= stats.MagicalResistance.multiplier;
        playerStats.CritRate.multiplier /= stats.CritRate.multiplier;
        playerStats.CritDamage.multiplier /= stats.CritDamage.multiplier;
        playerStats.Accuracy.multiplier /= stats.Accuracy.multiplier;
        playerStats.Speed.multiplier /= stats.Speed.multiplier;
    }
}
