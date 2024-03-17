using System;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using UnityEngine;

[Serializable] // FOR TESTING, CAN DELETE
public class Effect
{
    public Effect(string name, string description, Sprite sprite, float duration){
        this.name = name;
        this.description = description;
        this.sprite = sprite;
        this.duration = duration;
    }
    public string name;
    public string description;
    public Sprite sprite;
    public float duration;

    List<Modifier> modifiers = new();

    public Effect Init(){
        _ = OnEffect();
        return this;
    }

    public Effect AddModifier(Modifier modifier){
        modifiers.Add(modifier);
        return this;
    }

    public async UniTask OnEffect(){
        foreach (var modifier in modifiers){
            Debug.Log("start");
            modifier.StartOperation();
        }
        while (duration > 0){
            // FIX: DelayFrame
            await UniTask.Delay(TimeSpan.FromSeconds(1), DelayType.DeltaTime, PlayerLoopTiming.Update);
            // FIX: duration -= deltaTime;
            duration -= 1;
        }
        foreach (var modifier in modifiers){
            Debug.Log("stop");
            modifier.StopOperation();
        }
    }
}
