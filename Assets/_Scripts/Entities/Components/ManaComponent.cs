using System;
using Cysharp.Threading.Tasks;
using UnityEngine;

public class ManaComponent : MonoBehaviour, VisitableComponent
{
    [Header("Stats")]
    [SerializeField] private float currentMP;
    public float CurrentMP { get {return currentMP;} set {currentMP = value;}}
    [SerializeField] private float maxMP;
    public float MaxMP { get {return maxMP;} set {maxMP = value;}}
    [SerializeField] private float regeneratedMP;
    public float RegeneratedMP { get {return regeneratedMP;} set {regeneratedMP = value;}}

    public void Accept(ComponentVisitor visitor){
        visitor.Visit(this);
    }

    private void Awake(){
        currentMP = maxMP;
    }

    private async void Start(){
        await Regenerate();
    }

    private void FixedUpdate(){
        currentMP = Mathf.Clamp(currentMP, 0, maxMP);
    }

    private async UniTask Regenerate(){
        if (currentMP >= maxMP){
            currentMP = maxMP;
        }
        else {
            currentMP += regeneratedMP;
        }
        await UniTask.Delay(TimeSpan.FromSeconds(1), DelayType.DeltaTime, PlayerLoopTiming.Update);
        await Regenerate();
    }
}
