using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
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

    private async void Start(){
        currentMP = maxMP;
        await Regenerate();
    }

    private void FixedUpdate(){
        currentMP = Mathf.Clamp(currentMP, 0, maxMP);
    }

    private async Task Regenerate(){
        if (currentMP >= maxMP){
            currentMP = maxMP;
        }
        else {
            currentMP += regeneratedMP;
        }
        await Task.Delay(100);
        await Regenerate();
    }
}
