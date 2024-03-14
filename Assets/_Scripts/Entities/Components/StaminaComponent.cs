using System;
using Cysharp.Threading.Tasks;
using UnityEngine;

public class StaminaComponent : MonoBehaviour, VisitableComponent
{
    [Header("Stats")]
    [SerializeField] private float currentSP;
    public float CurrentSP { get {return currentSP;} set {currentSP = value;}}
    [SerializeField] private float maxSP = 100;
    public float MaxSP { get {return maxSP;} set {maxSP = value;}}
    [SerializeField] private float regeneratedSP = 1;
    public float RegeneratedSP { get {return regeneratedSP;} set {regeneratedSP = value;}}

    public void Accept(ComponentVisitor visitor){
        visitor.Visit(this);
    }

    private void Awake(){
        currentSP = maxSP;
    }

    private async void Start(){
        await Regenerate();
    }

    private void FixedUpdate(){
        currentSP = Mathf.Clamp(currentSP, 0, maxSP);
    }

    private async UniTask Regenerate(){
        if (currentSP >= maxSP){
            currentSP = maxSP;
        }
        else {
            currentSP += regeneratedSP;
        }
        await UniTask.Delay(TimeSpan.FromSeconds(0.1f), DelayType.DeltaTime, PlayerLoopTiming.Update);
        await Regenerate();
    }
}
